using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegexTest_2015
    {
    public partial class Form1 : Form
        {
        //-----------------------------------------------------
        bool MATCH;
        string SUBCAD = "";
        string C = "";
        string P = "";
        System.Text.RegularExpressions.MatchCollection MC;
        System.Text.RegularExpressions.Match W;
        int Coincidencias = 0;
        //-----------------------------------------------------
        int SecuenciaMatch = 1;
        int SecuenciaReplace = 1;
        int SecuenciaSplit = 1;
        //-----------------------------------------------------
        bool English = true;
        //-----------------------------------------------------
        // Tiempo máximo para evaluar un patrón: algunos patrones
        // (por ejemplo "(a+)+$") pueden tardar años con ciertas
        // cadenas y dejarían el programa congelado.
        //-----------------------------------------------------
        static readonly TimeSpan TIEMPO_MAXIMO = TimeSpan.FromSeconds(2);
        //-----------------------------------------------------
        // Escribe en MENSAJES el motivo real del error: patrón
        // mal escrito (con la explicación de .NET) o que tarda
        // demasiado.
        //-----------------------------------------------------
        void MensajeError(Exception E, string OperacionEng, string OperacionEsp)
            {
            if (E is RegexMatchTimeoutException)
                {
                if (English)
                    MENSAJES.AppendText(OperacionEng + " Error - The pattern takes too long (more than 2 seconds) - Please Rectify\n");
                else
                    MENSAJES.AppendText("Error en " + OperacionEsp + " - El patrón tarda demasiado (más de 2 segundos) - Rectifique\n");
                }
            else
                {
                if (English)
                    MENSAJES.AppendText(OperacionEng + " Error - Invalid Pattern - Please Rectify: " + E.Message + "\n");
                else
                    MENSAJES.AppendText("Error en " + OperacionEsp + " - Patrón no válido - Rectifique: " + E.Message + "\n");
                }
            }
        //-----------------------------------------------------
        // Prepara un texto para escribirlo dentro de @"..." en el
        // código generado (las comillas se escriben dobles).
        //-----------------------------------------------------
        static string Literal(string Texto)
            {
            return Texto.Replace("\"", "\"\"");
            }
        public Form1()
            {
            English = true;
            InitializeComponent();
            PATRON.Select();
            richTextBoxCODIGO.Text = "";
            CodigoEncabezamiento();
            }

        private void button1_Click(object sender, EventArgs e)
            {
            //----------------------------------------------------
            SUBCAD = "";
            C = "";
            P = "";
            Coincidencias = 0;
            //----------------------------------------------------
            listBox1.Items.Clear();
            MENSAJES.Text = "";
            Coincidencias = 0;
            COINCIDEN.Text = "";
            //----------------------------------------------------
            P = PATRON.Text;
            C = CADENA.Text;
            //----------------------------------------------------
            try
                {
                Regex R = new Regex(P, RegexOptions.None, TIEMPO_MAXIMO);
                MATCH = R.IsMatch(C);
                if (!MATCH)
                    {
                    if (English)
                        {
                        MENSAJES.Text = "Not coincidence with the pattern";
                        }
                    else
                        {
                        MENSAJES.Text = "No hay coincidencia con el patrón";
                        }

                    return;
                    }
                if (English)
                    {
                    MENSAJES.Text = "Matches Detected";
                    }
                else
                    {
                    MENSAJES.Text = "Matches Detectados";
                    }
                MC = R.Matches(C);
                Coincidencias = MC.Count;
                COINCIDEN.Text = Coincidencias.ToString();
                W = R.Match(C); // Pongo la 1ra subcadena en W
                for (int i = 1; i <= Coincidencias; i++)
                    {
                    listBox1.Items.Add(W);
                    SUBCAD = W.Value;
                    W = W.NextMatch();
                    }
                GeneraIsMatch();
                }
            //----------------------------------------------------
            catch (Exception E)
                {
                // Antes decía "No hay coincidencia" aunque el patrón estuviera mal escrito
                MensajeError(E, "Test", "Test");
                return;
                }
            //----------------------------------------------------
            }

        private void Reemplazar_Click(object sender, EventArgs e)
            {
            //----------------------------------------------------
            // Se toman el patrón y la cadena que hay AHORA en pantalla
            // (antes se usaban los del último TEST)
            P = PATRON.Text;
            C = CADENA.Text;
            try
                {
                listBox1.Items.Clear();
                CadenaReemplazada.Text = Regex.Replace(C, P, ReemplazarPor.Text, RegexOptions.None, TIEMPO_MAXIMO);
                GeneraReplace();
                }
            //----------------------------------------------------
            catch (Exception E)
                {
                MensajeError(E, "Replace", "Reemplazamiento");
                return;
                }
            //-----------------------------------------------------  
            }

        private void SPLIT_Click(object sender, EventArgs e)
            {
            //----------------------------------------------------
            // Se toman el patrón y la cadena que hay AHORA en pantalla
            // (antes se usaban los del último TEST)
            P = PATRON.Text;
            C = CADENA.Text;
            try
                {
                listBox1.Items.Clear();
                string[] CadenaSplit = Regex.Split(C, P, RegexOptions.None, TIEMPO_MAXIMO);
                for (int IDX = 0; IDX < CadenaSplit.Length; IDX++)
                    {
                    listBox1.Items.Add(CadenaSplit[IDX]);
                    }
                GeneraSplit();
                }
            //----------------------------------------------------
            catch (Exception E)
                {
                MensajeError(E, "Split", "Split");
                return;
                }
            //-----------------------------------------------------  
            }
        //-----------------------------------------------------
        public void CodigoEncabezamiento()
            {
            if (English)
                {
                richTextBoxCODIGO.Text = "  //==========================================================================\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //                          USING's for Regex\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //                   < Generated Code By RegexTestHF >\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //==========================================================================\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // The code generated by RegexTestHF shown below has as objetive to provide\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // you with a template that can be easily modified by you and be inserted \n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // in any region of your program.\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // This template assumes the existence of two textBox named:\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // - CADENA.Text\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // - PATRON.Text\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // It also assumes the existence of a listBox named:\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // - <listBox1>\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // For this reason, if you have the string to parse in a variable of type\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // string, like the pattern, it will suffice to do a simple search with\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // replacement so that the implicit names of the textBox above are replaced\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // by the names of the variables you want\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //==========================================================================\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "      using System.Text.RegularExpressions;\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //==========================================================================\n";
                }
            else
                {
                richTextBoxCODIGO.Text = "  //==========================================================================\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //                USING's de Encabezamiento Para Regex\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //                   < CODIGO GENERADO POR RegexTestHF >\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //==========================================================================\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // El código generado por RegexTestHF que se muestra a continuación tiene como\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // objetivo brindarle una plantilla que pueda ser modificada con facilidad por\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // usted y ser insertada en cualquier región de su programa.\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // Esta plantilla supone la existencia de dos textBox denominados:\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // - CADENA.Text\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // - PATRON.Text\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // También supone la existencia de un listBox denominado:\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // - <listBox1>\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // Por tal razón, si Ud. tiene la cadena a analizar en una variable de tipo\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // string, al igual que el patrón, bastará con hacer una sencilla busqueda\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // con reemplazamiento a fin de que los nombres implícitos de los textBox\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // anteriores sean sustituidos por los nombres de las variables que Ud. desea\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //==========================================================================\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "      using System.Text.RegularExpressions;\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //==========================================================================\n";
                }

            }
        //-----------------------------------------------------------------------------------------
        public void GeneraIsMatch()
            {
            if (English)
                {
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //==========================================================================\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //                         IsMatch() Code\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //==========================================================================\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                                         "      if  (Regex.IsMatch(@\"" +
                                         Literal(CADENA.Text) +
                                         "\",@\"" +
                                         Literal(PATRON.Text) +
                                         "\"))\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "          {\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "          // Put here the code if match is true\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "          }\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "      else\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "          {\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "          // Put here the code if match is false\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "          }\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // The Coincidences Number is Set in the integer Variable CoincidenciasN\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                                         "      int Coincidencias" + SecuenciaMatch + " = Regex.Matches(@\"" +
                                         Literal(CADENA.Text) +
                                         "\",@\"" +
                                         Literal(PATRON.Text) +
                                         "\").Count;\n";
                SecuenciaMatch++;
                }
            else
                {
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //==========================================================================\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //                         Código de IsMatch()\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //==========================================================================\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                                         "      if  (Regex.IsMatch(@\"" +
                                         Literal(CADENA.Text) +
                                         "\",@\"" +
                                         Literal(PATRON.Text) +
                                         "\"))\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "          {\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "          // Poner aquí código de si SE CUMPLE el match\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "          }\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "      else\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "          {\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "          // Poner aquí código de si NO SE CUMPLE el match\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "          }\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // A continuación se obtiene en la variable CoincidenciasN los Matches Obtenidos\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                                         "      int Coincidencias" + SecuenciaMatch + " = Regex.Matches(@\"" +
                                         Literal(CADENA.Text) +
                                         "\",@\"" +
                                         Literal(PATRON.Text) +
                                         "\").Count;\n";
                SecuenciaMatch++;
                }

            }
        //-----------------------------------------------------------------------------------------
        public void GeneraReplace()
            {
            if (English)
                {
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //==========================================================================\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //                         The Replace() Code\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //==========================================================================\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                                         "      string CadenaReemplazada" + SecuenciaReplace + " = Regex.Replace(@\"" +
                                         Literal(CADENA.Text) +
                                         "\",@\"" +
                                         Literal(PATRON.Text) +
                                          "\",@\"" +
                                         Literal(ReemplazarPor.Text) + "\");\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //==========================================================================\n";
                SecuenciaReplace++;
                }
            else
                {
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //==========================================================================\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //                         Código de Replace()\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //==========================================================================\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                                         "      string CadenaReemplazada" + SecuenciaReplace + " = Regex.Replace(@\"" +
                                         Literal(CADENA.Text) +
                                         "\",@\"" +
                                         Literal(PATRON.Text) +
                                          "\",@\"" +
                                         Literal(ReemplazarPor.Text) + "\");\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //==========================================================================\n";
                SecuenciaReplace++;
                }

            }
        //-----------------------------------------------------------------------------------------
        public void GeneraSplit()
            {
            if (English)
                {
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //==========================================================================\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //                         The Split() Code\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //==========================================================================\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // The Split() method extract all substrings not contained in the matches\n" +
                "  // substrings\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //==========================================================================\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "      string[] CadenaSplit" + SecuenciaSplit + " = Regex.Split(@\"" +
                                            Literal(CADENA.Text) +
                                            "\",@\"" +
                                            Literal(PATRON.Text) +
                                            "\");\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "      for (int IDX = 0; IDX < CadenaSplit" + SecuenciaSplit + ".Length; IDX++)\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "           {\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "           listBox1.Items.Add(CadenaSplit" + SecuenciaSplit + "[IDX]);\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "           }\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //==========================================================================\n";
                SecuenciaSplit++;
                }
            else
                {
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //==========================================================================\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //                         Código del Split()\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //==========================================================================\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  // El método Split() extrae todas las subcadenas no contenidas en las subcadenas\n" +
                "  // de coincidencias\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //==========================================================================\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "      string[] CadenaSplit" + SecuenciaSplit + " = Regex.Split(@\"" +
                                            Literal(CADENA.Text) +
                                            "\",@\"" +
                                            Literal(PATRON.Text) +
                                            "\");\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "      for (int IDX = 0; IDX < CadenaSplit" + SecuenciaSplit + ".Length; IDX++)\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "           {\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "           listBox1.Items.Add(CadenaSplit" + SecuenciaSplit + "[IDX]);\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "           }\n";
                richTextBoxCODIGO.Text = richTextBoxCODIGO.Text +
                "  //==========================================================================\n";
                SecuenciaSplit++;
                }

            }

        public void BTN_English_Click(object sender, EventArgs e)
            {
            EnglishFunction();
            }

        public void BTN_Spanish_Click(object sender, EventArgs e)
            {
            SpanishFunction();
            }

        public void SpanishFunction()
            {
            English = false;
            LBL_Pattern.Text = "Patrón de Validación";
            LBL_Coincidences.Text = "Coincidencias";
            LBL_EvaluationString.Text = "Cadena a Evaluar";
            LBL_ReplaceBy.Text = "Reemplazar por:";
            LBL_Messages.Text = "MENSAJES";
            LBL_ReplacedString.Text = "Cadena Reemplazada:";
            TEST.Text = "Test de Cadenas";
            CODIGO.Text = "Código C# Generado";
            ASCII.Text = "Tabla ASCII";
            UTF8.Text = "Tabla UTF8";
            }

        public void EnglishFunction()
            {
            English = true;
            LBL_Pattern.Text = "Pattern";
            LBL_Coincidences.Text = "Coincidences";
            LBL_EvaluationString.Text = "Evaluation String";
            LBL_ReplaceBy.Text = "Replace By:";
            LBL_Messages.Text = "MESSAGES";
            LBL_ReplacedString.Text = "Replaced String:";
            TEST.Text = "String Test";
            CODIGO.Text = "C# Generated Code";
            ASCII.Text = "ASCII Table";
            UTF8.Text = "UTF8 Table";
            }

        private void Form1_Load(object sender, EventArgs e)
            {
            English = true;
            EnglishFunction();
            }

        private void BTN_ResetCode_Click(object sender, EventArgs e)
            {
            richTextBoxCODIGO.Clear();
            SecuenciaMatch = 1;
            SecuenciaReplace = 1;
            SecuenciaSplit = 1;
            CodigoEncabezamiento();
            }

        //-----------------------------------------------------------------------------------------

        }
    }
