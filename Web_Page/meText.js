var btnMe = document.getElementById("btnMe");
var btnHobby = document.getElementById("btnHobby");
var btnContact = document.getElementById("btnContact");

var tab1Div = document.getElementById("tab1");

var projNam0 = document.getElementById("projNam0");
var projNam1 = document.getElementById("projNam1");
var projNam2 = document.getElementById("projNam2");
var projNam3 = document.getElementById("projNam3");
var projNam4 = document.getElementById("projNam4");

var projNamH20 = document.getElementById("projNamH20");
var projNamH21 = document.getElementById("projNamH21");
var projNamH22 = document.getElementById("projNamH22");
var projNamH23 = document.getElementById("projNamH23");
var projNamH24 = document.getElementById("projNamH24");

var projinfo0 = document.getElementById("pi0_text");
var projinfo1 = document.getElementById("pi1_text");
var projinfo2 = document.getElementById("pi2_text");
var projinfo3 = document.getElementById("pi3_text");
var projinfo4 = document.getElementById("pi4_text");

var infoEmail = document.getElementById("infoEmail");
var infoLinkedin = document.getElementById("infoLinkedin");
var infoLinkedin0 = document.getElementById("infoLinkedin0");
var infoGithub = document.getElementById("infoGithub");
var infoGithub0 = document.getElementById("infoGithub0");
var infoGithub1 = document.getElementById("infoGithub1");
var infoWebApp = document.getElementById("infoWebApp");
var infoWebApp0 = document.getElementById("infoWebApp0");



function swapLanguage(){
    
    if(document.getElementById("flagImage").src.substr(document.getElementById("flagImage").src.lastIndexOf('/')) == "/fin.jpg"){

        //Yläpalkki
        btnMe.innerHTML = "Minä";
        btnHobby.innerHTML = "Harrasteprojektit";
        btnContact.innerHTML = "Yhteystiedot ja Linkit";

        //Etusivu
        tab1Div.innerHTML ="<h1>Kuka olen?</h1> \
        <p>Hei, olen Timo Raivonen, tietotekniikan diplomi-insinööri. Sain viime joulukuussa opintoni valmiiksi ja olen nyt palaamassa takaisin työelämän pariin.</p> \
        <h1>Mitä osaan?</h1> \
        <p>Olen aikaisemmin toiminut ohjelmistosuunnittelijana laajassa projekteissa useamman vuoden ajan. Yhden koodarin tiiminä, työtehtäviini kuului ohjelmiston hallinnointi ja ohjelmointi C#, VB6 ja VBA kielillä. Kyseisten kielien lisäksi minulla on pintakosketusta moniin muihin ympäristöihin koulu- ja harrasteprojektien kautta.</p> \
        <h1>Mitä teen ja harrastan?</h1> \
        <p>Pidän ongelmien ratkaisemisesta ja en kaihda haasteita. Ohjelmoinnin lisäksi olen pitkään harrastanut pelejä niin tietokoneella kuin pöydän ääressä. Sen sijaan, että yritän löytää parhaat ratkaisut netistä, koitan miettiä pääni puhki löyttäkseni luovia ja tehokkaita vastauksia eteen tuleviin ongelmiin.</p> \
        <p>Rentouttavampana harrasteena käyn myös kävelyillä ja salilla, muokkailen kuvia ja kitaran soiton alkeita.</p>";
        
        //Projektit
        
        //Nettisivut        
        projNam0.innerHTML = "Nettisivut";
        projNamH20.innerHTML = "Nettisivut";

        projinfo0.innerHTML ="Olen jo jonkin aikaa miettinyt mikä olisi minulle hyvä tapa järjestää harrasteprojektejani siten, että pystyn helposti esittelemään niitä halutessani. Päätin vihdoin thedä yksinkertaisen nettisivun, missä pystyn listaamaan lyhyesti kuvauksen projekteistani ja linkkaamaan githubiin esimerkkikoodiin. <br /><br /> \
        Nämä sivut on tehty yksinkertaisesti HTML:n, JavaScriptin ja CCS:n kanssa frontend toteutuksena. Yksinkertaisuuden ideana on se, että jos haluan tehdä jotain monimutkaisempaa, niin luon sen erillisenä projektina ja näin pystyn saamaan nämä sivut alustavasti verkkoon mahdollisimman nopeasti. <br /><br /> \
        Avainsanat: HTML, JavaScript, CSS";
        
        //Demoprojekti        
        projNam1.innerHTML = "Map Flipper";
        projNamH21.innerHTML = "Map Flipper";

        projinfo1.innerHTML ="Map Flipperin oli osa Code Bootcamppia jonka aikana käytiin ohjelmoinnin perusteita ja tarkemmin web appien luomista. Itse en ole aikaisemmin tehnyt mitään varsinaista ASP.NET projektia, joten keskityin bootcampin lyhyessä saamaan aikaiseksi jotain toimivaa. Webapp luo ääriviivoilla tehdystä kuvasta yksinkertaisen ja käyttökelpoisen kartan perinteisiä pöytäroolipelejä varten. <br /><br /> \
        ASP.NET Core projektissa on backendinä C# ääriviivakartan analysoimiseen ja kartan piirtämiseen JavaScript ja Razor. Kartan piirto on toteutettu HTML5 Canvas elementin avulla, johon pystyy piirtämään JavaScriptistä proseduraalisesti ruutu kerrallaan. <br /><br /> \
        Avainsanat: ASP.NET Core, C#, Razor, JavaScript";
        // Projekti on tarkoitus tehdä vielä bootcampin jälkeen paremmaksi. Muutettuani toimien järjestystä, pystyy kuvan palauttamaan näkyväksi selaimeen tallentamatta sitä serverille siinä välissä. Tässä kohtaa minulla on tarkoitus julkaista appi kaikkien käytettäväksi. <br /><br /> \
        
        //Kuvamuokkaus        
        projNam2.innerHTML = "Kuvankäsittely";
        projNamH22.innerHTML = "Kuvankäsittely";

        projinfo2.innerHTML ="Olen jo pitkään käyttänyt GIMP:iä satunnaiseen kuvien luomiseen, käsittelyyn ja muuntamiseen. Iso osa tästä harrasteesta on keskittynyt vitsien luomiseen, roolipeleihin liittyvien kuvien muuntamiseen ja hetkellisten päähänpistosten testailuun. Yleensä myös luon tarvitsemiani tekstuureita ohjelmistoprojekteihin, kuten esimerkiksi Map Flipper projektiin. <br /><br /> \
        Avainsanat: GIMP";
        
        //Peliprojekti        
        projNam3.innerHTML = "Isompi Peliprojekti";
        projNamH23.innerHTML = "Isompi Peliprojekti";

        projinfo3.innerHTML ="Jo jokin aika sitten aloin luomaan pohjaa pelille Shrouded Valley, jonka tarkoituksena oli toimia ohjaimella ja käyttää kahta tikkuohjainta liikkumiseen ja kyökkäämiseen. Erona tavalliseen vastaavaa kontrollointia käyttävään peliin tarkoitus on, että oma hahmo käyttää lähitaisteluaseita ampumisen sijaan. Aseen liike mallinnetaan kolmiulotteisesti vastaamaan tikun asentoa, ja tikkua liikuttamalla hahmo iskee aseen kanssa eri suuntiin.<br /><br /> \
        Mitään valmista ohjaus tai pelikirjastoa pelin kehittämiseen ei ole käytetty, vaan päätarkoituksena oli itse luoda kaikki alusta asti niin, että modulaarisuus ja satunnainen generointi on hyvin vahvasti otettuna huomioon.<br /><br /> \
        Projetki on edennyt satunnaisesti, mutta alkeellisella tasolla vihollisia pystyy luomaan, niiden kanssa taistelemaan ja taloja generoimaan annettujen huonekokojen mukaan. <br /><br /> \
        Avainsanat: C#, Unity3D";
        
        //Pikkupeliprojektit
        projNam4.innerHTML = "Pikkupelejä";
        projNamH24.innerHTML = "Pikkupelejä";

        projinfo4.innerHTML ="Pienempiä peliprojekteja on tullut tehtyä yli 20 vuoden ajan QBasic tekstiseikkailuista Unity projekteihin. Yksi näistä peliprojekteista on yksinkertainen ja nopeasti tehty testailyprojekti, jossa pelaaja ohjaa palloa mikä liikkuu radalla. Haasteena pelaajalle radalla pysymisen lisäksi on taustan värin muuttuminen samaksi kuin itse rata, jolloin enää näkyviin jää välipisteet. <br /><br /> \
        Projekti ei ole mikään maata mullistava, vaan lähinnä testailua Unityn moottorilla.<br /><br /> \
        Avainsanat: C#, Unity3D";

        //Info&Linkit välilehti
        infoEmail.innerHTML = "Sähköposti";
        infoLinkedin.innerHTML = "LinkedIn";
        infoLinkedin0.innerHTML = "Linkedin Profiili";
        infoGithub.innerHTML = "Github";
        infoGithub0.innerHTML = "Yleinen Esimerkkikoodein Repository";
        infoGithub1.innerHTML = "Map Flipper Repository";
        infoWebApp.innerHTML = "Web Apit";
        infoWebApp0.innerHTML = "Map Flipper";

        document.getElementById("flagImage").src = "gb.jpg";
    }
    else{

        //Yläpalkki
        btnMe.innerHTML = "Me";
        btnHobby.innerHTML = "Hobby Projects";
        btnContact.innerHTML = "Contact and Links";

        //Etusivu
        tab1Div.innerHTML ="<h1>Who am I?</h1> \
        <p>Hi, I'm Timo Raivonen, Master of Science (Technology). I finished my studies at the end of 2019 and I'm looking to get back to work.</p> \
        <h1>What can I do?</h1> \
        <p>I have worked as a software developer in expansive projects for several years. As a one man coding team, my work consisted of handling all aspects of a traditional program and the programming was done with C#, VB6 and VBA. In addition to forementioned languages I have extensive surface feel of many other languages and techniques through school and hobby projects.</p> \
        <h1>What do I like to do and have as hobbies?</h1> \
        <p>I like solving problems and no not turn away from a challenge. In addition to programming I have been in to gaming on a computer and around a table for a long time. Instead of looking up best ways to play games, I like to tackle the challenges myself and find creative ways to solve them.</p> \
        <p>For more mentally relaxing hobbies, I also go for walks and to gym and also like to modify images and dabble a bit in to playing a guitar.</p>";
        
        //Projektit
        
        //Nettisivut        
        projNam0.innerHTML = "Web Page";
        projNamH20.innerHTML = "Web Page";

        projinfo0.innerHTML ="For quite some time I have been wondering what would be a good way to organize my hobby projects so, that I could present them quickly in a convinient way. I finally decided to create a simple web page, where I can give a quick explanation of my projects and provide links to example code. <br /><br /> \
        This web page are made to be simple HTML web page with JavaScript and css as the frontend implementation. The basic idea was to have the page up to represent my hobby projects and if I desired to do anything more complicated, it would be done as a seperate project. <br /><br /> \
        Keywords: HTML, JavaScript, CSS";
        
        //Demoprojekti        
        projNam1.innerHTML = "Map Flipper";
        projNamH21.innerHTML = "Map Flipper";

        projinfo1.innerHTML ="Map Flipper was started as a part of Code Bootcamp that focused on creating web apps. Before the bootcamp I haven't hade any ASP.NET projects, so my project focused on something that I knew I could get working in few weeks. The web app creates a map usable in traditional roleplaying games from a wireframe image. <br /><br />\
        In the ASP.NET Core project C# is used as the backend language to analyze the original image. For the frontend the project uses Razor and JavaScript. The drawing of the map is done by using a HTML5 canvas, that is drawn on procedurally one square at a time with JavaScript. <br /><br /> \
        Keywords: ASP.NET Core, C#, Razor, JavaScript";
        // Projekti on tarkoitus tehdä vielä bootcampin jälkeen paremmaksi. Muutettuani toimien järjestystä, pystyy kuvan palauttamaan näkyväksi selaimeen tallentamatta sitä serverille siinä välissä. Tässä kohtaa minulla on tarkoitus julkaista appi kaikkien käytettäväksi. <br /><br /> \
        
        //Kuvamuokkaus        
        projNam2.innerHTML = "Image Processing";
        projNamH22.innerHTML = "Image Processing";

        projinfo2.innerHTML ="For a long time I have occosianally used GIMP for creating textures, processing images and creating maps. Big part of this hobby has centered around creating jokes, modifying existing images for use of pen and paper roleplay and for testing things that have felt like interesting things to try. Some of the created textures can be seen on the Map Flipper project.<br /><br /> \
        Keywords: GIMP";
        
        //Peliprojekti        
        projNam3.innerHTML = "Major Game Project";
        projNamH23.innerHTML = "Major Game Project";

        projinfo3.innerHTML ="Few years ago I started creating base for a game called Shrouded Valley, which was meant to be a twin stick game. The main differences to many other games with the same similar control method is to mainly have a melee weapon instead of a ranged one. The weapon is controlled in a way that it is moved over and around your character as you move the right stick. <br /><br /> \
        I started creating the controlls and game engine from scratch and it was my intention to be able to learn about the Unity projects as I go. The engine is set up so that everything is meant to be as modular as possible. <br /><br /> \
        The project has only progressed from time to time, but at a basic level one can create enemies, fight with them and generate buildings. <br /><br /> \
        Keywords: C#, Unity3D";
        
        //Pikkupeliprojektit
        projNam4.innerHTML = "Mini Games";
        projNamH24.innerHTML = "Mini Games";

        projinfo4.innerHTML ="I have been coding smaller game projects for over 20 years from QBasic to Unity projects. Just as an example, one of these games is a game where the player moves a ball on a track. The challenge for the player is staying on the track while being fast enough to do it before the background is set to the same color as the track. <br /><br /> \
        The example project isn't anything too great, but more of an example of my testing with Unity engine.<br /><br /> \
        Keywords: C#, Unity3D";

        //Info&Linkit välilehti
        infoEmail.innerHTML = "E-mail";
        infoLinkedin.innerHTML = "LinkedIn";
        infoLinkedin0.innerHTML = "Linkedin Profile";
        infoGithub.innerHTML = "Github";
        infoGithub0.innerHTML = "General Example Repository";
        infoGithub1.innerHTML = "Map Flipper Repository";
        infoWebApp.innerHTML = "Web Apps";
        infoWebApp0.innerHTML = "Map Flipper";

        document.getElementById("flagImage").src = "fin.jpg";
    }
    
}

swapLanguage();
