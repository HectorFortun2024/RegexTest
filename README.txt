============================================================================
RegexTest 1.0  -  LÉAME / README
============================================================================

  Español: primera parte.   English: second part.

ESPAÑOL
-------

Qué es
------
  RegexTest (RegexTestHF) es un probador de expresiones regulares para
  programadores de C#: usted escribe el patrón, lo prueba sobre un texto y
  el programa genera al momento el código C# correspondiente. Incluye un
  manual de expresiones regulares en español y en inglés.
  Es gratuito y de código abierto. Este fichero explica cómo obtenerlo y por
  qué Windows puede mostrar un aviso al instalarlo, para que usted decida
  con toda la información.

Dos formas de obtenerlo: usted elige
------------------------------------
  A) El instalador ya preparado (SetupRegexTestHF.msi). Es lo más cómodo.
  B) El código fuente, para compilarlo usted mismo con Visual Studio
     Community, que es gratuito.
  Las dos formas dan exactamente el mismo resultado.

Sitio oficial: descárguelo solo de aquí
---------------------------------------
  El único sitio oficial de RegexTest es su página en GitHub, la del autor:
     https://github.com/HectorFortun2024/RegexTest
  Descargue el instalador y el código fuente solo desde esa página. La
  licencia MIT permite que otras personas copien RegexTest, así que pueden
  aparecer copias en otras webs. El autor no las revisa ni las controla, y
  cualquiera podría haberlas modificado para meter algo dañino. Si encuentra
  RegexTest en otro sitio, no lo use: vaya al enlace oficial.

  El autor no se hace responsable de lo que pueda ocurrir con una copia
  obtenida fuera del sitio oficial, ni de no seguir las indicaciones de este
  fichero. La huella digital (explicada más abajo) le permite comprobar en
  un momento que su fichero es el original.

Por qué Windows puede mostrar un aviso
--------------------------------------
  El instalador no lleva "firma digital". Esa firma es un certificado que se
  compra cada año y que solo identifica a quien publica el programa: no
  analiza ni garantiza lo que el programa hace. Como RegexTest es gratuito,
  el autor ha preferido no pagarla.

  Por eso, al descargar o abrir el instalador, el navegador o Windows
  (SmartScreen) pueden decir que el fichero "no se descarga con frecuencia"
  o que es una "aplicación no reconocida". Es el aviso habitual para
  cualquier programa sin firma, por bueno que sea: no quiere decir que se
  haya encontrado nada malo en él.

  Si quiere comprobar que el fichero es exactamente el que publicó el autor,
  sin ningún cambio, compare su huella digital (se explica más abajo). Y si
  prefiere no ejecutar el instalador, tiene la forma B: el código completo
  está a su disposición.

A) Instalar con el instalador (.msi)
------------------------------------
  1. Descárguelo del enlace oficial:
     https://github.com/HectorFortun2024/RegexTest/releases/latest
  2. Si el navegador avisa de que el fichero no se descarga con frecuencia,
     elija la opción de conservarlo.
  3. Haga doble clic en el fichero. Si aparece la ventana azul
     "Windows protegió su PC", pulse "Más información" y después
     "Ejecutar de todas formas".
  4. Si Windows pregunta "¿Quiere permitir que esta aplicación haga cambios
     en el dispositivo?" con "Editor: desconocido", pulse "Sí".
     "Desconocido" solo significa que no lleva firma.
  5. Siga el asistente. Dónde queda cada cosa y cómo desinstalarlo se
     explica en "RegexTest - Guía de Instalación.pdf" (carpeta
     "DOCUMENTOS OFICIALES").

  Comprobar la huella digital (opcional):
     Abra PowerShell en la carpeta donde descargó el fichero y escriba:
        Get-FileHash "SetupRegexTestHF.msi"
     El valor que aparece en Hash debe ser exactamente este:
     C0ADA025AD791484F46A0421853F372E36D36695D8AE7D0E559A70D227FFE4F2
     Si no coincide, no lo instale y descárguelo de nuevo del enlace
     oficial.

B) Compilarlo usted mismo con Visual Studio Community
-----------------------------------------------------
  Así no ejecuta nada preparado por otra persona: el programa lo construye
  su propio Visual Studio a partir del código, que puede leer línea a línea
  antes de compilarlo.
  1. Instale Visual Studio Community (gratuito para particulares y para
     proyectos de código abierto). Durante la instalación marque
     "Desarrollo de escritorio de .NET". Se descarga de:
     https://visualstudio.microsoft.com/vs/community/
  2. Descargue el código: en la página del repositorio, botón verde "Code" y
     luego "Download ZIP". El repositorio está en:
     https://github.com/HectorFortun2024/RegexTest
  3. Antes de descomprimirlo: clic derecho sobre el ZIP, "Propiedades",
     marque "Desbloquear" y pulse "Aceptar". Así Visual Studio no tratará
     cada fichero como venido de Internet ni pondrá pegas al compilar.
  4. Descomprímalo y abra RegexTestHF.sln con Visual Studio. Si pregunta si
     confía en el proyecto, es su comprobación normal para todo lo que viene
     de Internet: conteste que sí.
  5. En la barra de arriba elija "Release" y pulse "Compilar" y luego
     "Compilar solución".
  6. El programa queda en RegexTest_2015\bin\Release\RegexTest_2015.exe .
     Puede ejecutarlo desde ahí o copiar la carpeta Release donde quiera.

  Requisito: .NET Framework 4.8.
  Si falta su "paquete de destino", Visual Studio ofrece instalarlo.

Un caso especial: Control inteligente de aplicaciones
-----------------------------------------------------
  Algunos equipos con Windows 11 tienen activado
  "Control inteligente de aplicaciones" (Smart App Control). Si es su caso,
  Windows bloquea cualquier programa sin firma, también el que usted
  compile, y no ofrece "Ejecutar de todas formas". Puede verlo en
  "Seguridad de Windows" > "Control de aplicaciones y navegador".
  Desactivarlo o no es decisión suya; en muchos equipos viene apagado.

Licencia
--------
  Licencia MIT: puede usarlo, copiarlo, modificarlo y distribuirlo
  libremente, también con fines comerciales. Texto completo en "DOCUMENTOS
  OFICIALES\End User Agreement.rtf".


============================================================================

ENGLISH
-------

What it is
----------
  RegexTest (RegexTestHF) is a regular expression tester for C# programmers:
  you write the pattern, test it on a text and the program instantly
  generates the matching C# code. It includes a regular expressions manual
  in Spanish and English.
  It is free and open source. This file explains how to get it and why
  Windows may show a warning when you install it, so you can decide with all
  the facts.

Two ways to get it: your choice
-------------------------------
  A) The ready-made installer (SetupRegexTestHF.msi). The easiest way.
  B) The source code, to build it yourself with Visual Studio Community,
     which is free.
  Both ways give exactly the same result.

Official site: download it only from here
-----------------------------------------
  The only official site for RegexTest is its GitHub page, the author's own:
     https://github.com/HectorFortun2024/RegexTest
  Download the installer and the source code only from that page. The MIT
  license allows other people to copy RegexTest, so copies may appear on
  other websites. The author does not review or control them, and anyone
  could have modified them to add something harmful. If you find RegexTest
  anywhere else, do not use it: go to the official link.

  The author is not responsible for anything that may happen with a copy
  obtained outside the official site, or from not following the instructions
  in this file. The digital fingerprint (explained below) lets you check in
  a moment that your file is the original.

Why Windows may show a warning
------------------------------
  The installer has no "digital signature". That signature is a certificate
  bought every year that only identifies who publishes the program: it does
  not analyze or guarantee what the program does. Since RegexTest is free,
  the author chose not to pay for it.

  That is why, when you download or open the installer, the browser or
  Windows (SmartScreen) may say the file "isn't commonly downloaded" or is
  an "unrecognized app". This is the usual warning for any unsigned program,
  however good it is: it does not mean anything bad was found in it.

  If you want to check that the file is exactly the one the author
  published, unchanged, compare its digital fingerprint (explained below).
  And if you prefer not to run the installer, you have way B: the complete
  source code is available to you.

A) Install with the installer (.msi)
------------------------------------
  1. Download it from the official link:
     https://github.com/HectorFortun2024/RegexTest/releases/latest
  2. If the browser warns that the file isn't commonly downloaded, choose
     the option to keep it.
  3. Double-click the file. If the blue window "Windows protected your PC"
     appears, click "More info" and then "Run anyway".
  4. If Windows asks "Do you want to allow this app to make changes to your
     device?" with "Publisher: Unknown", click "Yes". "Unknown" only means
     it is not signed.
  5. Follow the wizard. Where everything goes and how to uninstall it is
     explained in "RegexTest - Installation Guide.pdf" (folder
     "DOCUMENTOS OFICIALES").

  Checking the digital fingerprint (optional):
     Open PowerShell in the folder where you downloaded the file and type:
        Get-FileHash "SetupRegexTestHF.msi"
     The value shown under Hash must be exactly this:
     C0ADA025AD791484F46A0421853F372E36D36695D8AE7D0E559A70D227FFE4F2
     If it does not match, do not install it; download it again from the
     official link.

B) Build it yourself with Visual Studio Community
-------------------------------------------------
  This way you run nothing prepared by someone else: your own Visual Studio
  builds the program from the source code, which you can read line by line
  before building it.
  1. Install Visual Studio Community (free for individuals and for open
     source projects). During setup, tick ".NET desktop development".
     Download it from:
     https://visualstudio.microsoft.com/vs/community/
  2. Download the code: on the repository page, green "Code" button, then
     "Download ZIP". The repository is at:
     https://github.com/HectorFortun2024/RegexTest
  3. Before unzipping it: right-click the ZIP, "Properties", tick "Unblock"
     and click "OK". This way Visual Studio will not treat every file as
     coming from the Internet or object when building.
  4. Unzip it and open RegexTestHF.sln with Visual Studio. If it asks
     whether you trust the project, that is its normal check for anything
     coming from the Internet: answer yes.
  5. In the top bar choose "Release" and click "Build", then
     "Build Solution".
  6. The program is in RegexTest_2015\bin\Release\RegexTest_2015.exe . You
     can run it from there or copy the Release folder wherever you like.

  Requirement: .NET Framework 4.8.
  If its "targeting pack" is missing, Visual Studio offers to install it.

A special case: Smart App Control
---------------------------------
  Some Windows 11 computers have "Smart App Control" turned on. If yours
  does, Windows blocks any unsigned program, including the one you build
  yourself, and does not offer "Run anyway". You can check it in
  "Windows Security" > "App & browser control". Whether to turn it off is
  your decision; on many computers it comes turned off.

License
-------
  MIT license: you may use, copy, modify and distribute it freely, including
  for commercial purposes. Full text in "DOCUMENTOS OFICIALES\End User
  Agreement.rtf".


----------------------------------------------------------------------------
Autor / Author: Héctor Fortún Castañón
