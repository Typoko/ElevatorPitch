var tab1Div = document.getElementById("tab1");

tab1Div.innerHTML +="<h1>Kuka olen?</h1> \
<p>Hei, olen Timo Raivonen, tietotekniikan diplomi-insinööri. Sain viime joulukuussa opintoni valmiiksi ja olen nyt palaamassa takaisin työelämän pariin.</p> \
<h1>Mitä osaan?</h1> \
<p>Olen aikaisemmin toiminut ohjelmistosuunnittelijana laajassa projekteissa useamman vuoden ajan. Yhden koodarin tiiminä, työtehtäviini kuului ohjelmiston hallinnointi ja ohjelmointi C#, VB6 ja VBA kielillä. Kyseisten kielien lisäksi minulla on pintakosketusta moniin muihin ympäristöihin koulu- ja harrasteprojektien kautta.</p> \
<h1>Mitä teen ja harrastan?</h1> \
<p>Pidän ongelmien ratkaisemisesta ja en kaihda haasteita. Ohjelmoinnin lisäksi olen pitkään harrastanut pelejä niin tietokoneella kuin pöydän ääressä. Sen sijaan, että yritän löytää parhaat ratkaisut netistä, koitan miettiä pääni puhki löyttäkseni luovia ja tehokkaita vastauksia eteen tuleviin ongelmiin.</p> \
<p>Rentouttavampana harrasteena käyn myös kävelyillä ja salilla, muokkailen kuvia ja kitaran soiton alkeita.</p>";

//Nettisivut
var projinfo1 = document.getElementById("pi1_text");

projinfo1.innerHTML +="Olen jo jonkin aikaa miettinyt mikä olisi minulle hyvä tapa järjestää harrasteprojektejani siten, että pystyn helposti esittelemään niitä halutessani. Päätin vihdoin thedä yksinkertaisen nettisivun, missä pystyn listaamaan lyhyesti kuvauksen projekteistani ja linkkaamaan githubiin esimerkkikoodiin. <br /><br /> \
Nämä sivut on tehty yksinkertaisesti HTML:n, JavaScriptin ja CCS:n kanssa frontend toteutuksena. Yksinkertaisuuden ideana on se, että jos haluan tehdä jotain monimutkaisempaa, niin luon sen erillisenä projektina ja näin pystyn saamaan nämä sivut alustavasti verkkoon mahdollisimman nopeasti. <br /><br /> \
Avainsanat: HTML, JavaScript, CSS";

//Demoprojekti
var projinfo2 = document.getElementById("pi2_text");

projinfo2.innerHTML +="Map Flipperin oli osa Code Bootcamppia jonka aikana käytiin ohjelmoinnin perusteita ja tarkemmin web appien luomista. Itse en ole aikaisemmin tehnyt mitään varsinaista ASP.NET projektia, joten keskityin bootcampin lyhyessä saamaan aikaiseksi jotain toimivaa. Webapp luo ääriviivoilla tehdystä kuvasta yksinkertaisen ja käyttökelpoisen kartan perinteisiä pöytäroolipelejä varten. <br /><br /> \
ASP.NET Core projektissa on backendinä C# ääriviivakartan analysoimiseen ja kartan piirtämiseen JavaScript ja Razor. Kartan piirto on toteutettu HTML5 Canvas elementin avulla, johon pystyy piirtämään JavaScriptistä proseduraalisesti ruutu kerrallaan. <br /><br /> \
Avainsanat: ASP.NET Core, C#, Razor, JavaScript";
// Projekti on tarkoitus tehdä vielä bootcampin jälkeen paremmaksi. Muutettuani toimien järjestystä, pystyy kuvan palauttamaan näkyväksi selaimeen tallentamatta sitä serverille siinä välissä. Tässä kohtaa minulla on tarkoitus julkaista appi kaikkien käytettäväksi. <br /><br /> \

//Kuvamuokkaus
var projinfo3 = document.getElementById("pi3_text");

projinfo3.innerHTML +="Olen jo pitkään käyttänyt GIMP:iä satunnaiseen kuvien luomiseen, käsittelyyn ja muuntamiseen. Iso osa tästä harrasteesta on keskittynyt vitsien luomiseen, roolipeleihin liittyvien kuvien muuntamiseen ja hetkellisten päähänpistosten testailuun. Yleensä myös luon tarvitsemiani tekstuureita ohjelmistoprojekteihin, kuten esimerkiksi CBC Demoprojektiin. <br /><br /> \
Avainsanat: GIMP";

//Peliprojekti
var projinfo4 = document.getElementById("pi4_text");

projinfo4.innerHTML +="Jo jokin aika sitten aloin luomaan pohjaa pelille Shrouded Valley, jonka tarkoituksena oli toimia ohjaimella ja käyttää kahta tikkuohjainta liikkumiseen ja kyökkäämiseen. Erona tavalliseen vastaavaa kontrollointia käyttävään peliin tarkoitus on, että oma hahmo käyttää lähitaisteluaseita ampumisen sijaan. Aseen liike mallinnetaan kolmiulotteisesti vastaamaan tikun asentoa, ja tikkua liikuttamalla hahmo iskee aseen kanssa eri suuntiin.<br /><br /> \
Mitään valmista ohjaus tai pelikirjastoa pelin kehittämiseen ei ole käytetty, vaan päätarkoituksena oli itse luoda kaikki alusta asti niin, että modulaarisuus ja satunnainen generointi on hyvin vahvasti otettuna huomioon.<br /><br /> \
Projetki on edennyt satunnaisesti, mutta alkeellisella tasolla vihollisia pystyy luomaan, niiden kanssa taistelemaan ja taloja generoimaan annettujen huonekokojen mukaan. <br /><br /> \
Avainsanat: C#, Unity3D";

//Pikkupelit
var projinfo5 = document.getElementById("pi5_text");

projinfo5.innerHTML +="Pienempiä peliprojekteja on tullut tehtyä yli 20 vuoden ajan QBasic tekstiseikkailuista Unity projekteihin. Yksi näistä peliprojekteista on yksinkertainen ja nopeasti tehty testailyprojekti, jossa pelaaja ohjaa palloa mikä liikkuu radalla. Haasteena pelaajalle radalla pysymisen lisäksi on taustan värin muuttuminen samaksi kuin itse rata, jolloin enää näkyviin jää välipisteet. <br /><br /> \
Projekti ei ole mikään maata mullistava, vaan lähinnä testailua Unityn moottorilla.<br /><br /> \
Avainsanat: C#, Unity3D";
