# Bemutatkozó
Az Ekecluded egy világszerte ismert fejlesztő csapat akik hatalmas dolgokat képesek elérni közösen, a tagok között kialakult remek kapcsolat és programozási tapasztalataik segítségével. A csapat 6 tagból áll, a csapat 2018-ban alakult.
A jelenlegi projektünk egy 3d-s Pac-Man játék elkészítése.
## Tagok:
- Alexa Kornél
- Barkóczi Martin
- Farkas Balázs
- Horváth Gábor
- Horváth István
- Tóth Noémi Evelin
# Jelenlegi helyzet
A Pac-Man a Namco játéka, amelyet 1980-ban adtak ki a játéktermekbe, és később különféle platformokra. Igazi klasszikussá vált, a világ egyik legismertebb játéka. A játék egy labirintusban játszódik, amelyben egy kis sárga fejet kell irányítani. A cél az, hogy a pontokat megegye, és elkerülje a négy szellem ellenséget, amelyek el akarják kapni Pac-Man-t. Már a bemutatásánál nagyon népszerű játék lett. Ebből adódóan az emberek többsége szívesen játszana egy új, modernebb verzióval, Ezen felül a fiatalabb korosztályok is megismerkedhetnek a Pac-Man fantasztikus világával.
# Vágyálom rendszer
A projekt célja egy 3D Pac-man megvalósítása, amely a felhasználók kikapcsolódását segít elő. Az alkalmazás Windows operációs rendszereken lesz elérhető. Az alkalmazás elindítása után a játékosok egy színes menü oldalt fognak látni, amely majd felkelti a figyelmüket. A menü oldalon történő navigáció könnyű, egszerű lesz a felhasználó élmények javítása érdekében. A menüben egy játék, egy toplista, egy shop és egy beállítások fül lesz majd látható. A játék lehetőséget fog nyújtani a felhasználok teljesítményének tárolására (toplista), ennek segítségével másokkal is összemérhetik ügyességüket. A játék során elért pontjainkat a későbbiekben fel tudják majd használni a gyüjthető kinézeti elemek megvásárlására, ezek a gyüjthető elemek cserélhetőek lesznek, hogy a saját karakterünk kinézetét egyénivé tehessük vagy akár más pálya kinézettel is játszhassunk. A gyüjthető elemek sapkák különböző arcok és pálya kinézeteket lesznek, amelyet a shop-ban lehet majd megvenni, az értékük pedig eltérő lesz. A pontszámokat egy adatbázisban fogjuk tárolni, amelyben az adatfeltöltés során a játékosok egy álltaluk megadott nevet adhatnak meg, ideális esetben a felhasználók álltal megadott nevek egyediek lesznek, ezáltal az adatbázisban nem láthatjuk kétszer ugyan azt a nevet. A játék közben különböző power up-okat lehet majd gyüjteni mint például a gyorítás vagy akár egy olyan power up-ot is fel lehet venni amivel a ghostokat is meg lehet majd enni, ezek a power upok a pálya ülönböző részein lesznek véletlenül elhelyezve. A pontokat minden megevett coin vagy ghost után fognak kapni a játékosok, a cél minél több pont összegyüjtése lesz a lehető legrövidebb idő alatt.
# A rendszerre vonatkozó pályázat, törvények, rendeletek, szabványok és ajánlások felsorolása
Számítógépes aplikációként a következő szabványok vonatkoznak ránk.
## Általános szabványok
- Muszáj könnyen használhatónak lenni a célközönség számára.
- Logikusan kell működnie a célközönség számára.
- Haszálnia kell az iparág legjobb gyakorlatait.
## Fejlesztési technológia, Programozási nyelv
Az alkalmazás a következő(vagy fejlettebb) technológíákat használja:
- Unity
- C Sharp 8.0
Ajánlott fejlesztői környezet:
- Unity Editor
- Microsoft Visual Studio 2017 15.9.11
## Minimum szabványok
Az alkalmazásnak megfelelően kell működnie és megjelennie a következő operácós rendszereken:
- Windows 7
- Windows 8
- Windows 10
## Minimum gépigény
- CPU: Intel Core i5
- RAM: 8 GB RAM
- GPU: NVIDIA GeForce 920M
- Tárhely: 1 GB
# Jelenlegi üzleti folyamatok modellje
A mai Pac-Man játékok nem használják ki a modern számítógépek nyújtotta lehetőségeket. Jelenleg sokan csak 2D-s változatát ismerik. A mai grafikus motorokkal már 3D-s változatot is lehet készíteni mely nagy előrelépés lenne a felhasználók élményeinek javításában.
# Igényelt üzleti folyamatok modellje

# Követelménylista
## Funkcionális:
- Mozgatás megtervezése és létrehozása
- Pontozási rendszer megtervezése és létrehozása
- Random pont generálása képernyőre
- Ellenség mozgása
- Játék mechanikák
## Nem funkcionális:
- Pálya megtervezése
- Grafikai elemek megtervezése
- Egyértelmű felhasználói felület megtervezése és létrehozása
- Adatbázis megtervezése és megvalósítása

| Modul       | Id | Név                    | Leírás                                           |
|:-----------:|:--:|:----------------------:|:------------------------------------------------:|
| Dizájn      | D1 | Grafikai elemek        | Grafikai elemek megtervezése és elkészítése      |
| Dizájn      | D2 | Felhasználói felület   | Felhasználói felület megtervezése és létrehozása |
| Dizájn      | D3 | Páya tervezés          | Pálya megtervezése és megvalósítása              |
| Játékmenet  | J1 | Irányítás              | Mozgatás implementálása                          |
| Játékmenet  | J2 | Pontozási rendszer     | Pontozási rendszer megvalósítása                 |
| Játékmenet  | J3 | Random pont generálás  | Random pont generálása a képernyőre              |
| Játékmenet  | J4 | Ellenség mozgása       | Ellenségek mozgásának megvalósítása              |
| Játékmenet  | J5 | Játék mechanikák       | Játékmechanikák megtervezése és létrehozása      |
| Adatbázis   | A1 | Adatbázis megtervezése | Adatbázis megtervezése és létrehozása            |
| Adatbázis   | A2 | Adatbázis kapcsolat    | Adatbázis kapcsolat létrehozása a játékban       |

# Irányított ás szabad szöveges riportok szövege
**Megrendelő:** Szeretnék egy igényes és ízléses 3D Pac-Man játékot, amiben kell legyen egy főmenü, ahova a program indítás után betölt. A főmenüben három opciónak kell lennie, ez a három opció a Játék indítása, Ranglista, Kilépés. Továbbá szeretném ha a Játék indítása opcióval indulna el a játékmenet, ahol először egy nevet kell megadni. A név megadása után a játéknak kell indulnia, ahol a karaktert irányítva pontokat kell gyüjteni úgy, hogy az ellenséget elkerüljük. A játék elbukása után lennie kell egy új játék kezdése opciónak, amivel teljesen új játékmenetet kell biztosítani. Ezenfelül kell legyen egy kilépés a főmenübe opció, amivel a főmenübe tölt a program. Az általam igényelt játékmeneten felül lennie kell egy Ranglistának is, amit a főmenüből érhetek el a Ranglista opció kiválasztásával. A ranglitsán a legjobb tíz elért pontszámnak kell megjelennie rangsorolva. A ranglista menüpontban lennie kell egy vissza a főmenübe opciónak aminek kiválasztásával a program vissza tölti a főmenüt ahol új játékot lehet kezdeni vagy a Kilépés opcióval bezárható a program.

**Ekecluded:** A Ranglistán szerepelhet több felhaszáló ugyan azzal a névvel? Illetve lehet ugyan az a felhasználó név több jétékosnak egyszerre?

**Megrendelő:** Szerepelhet több felhasználó a ranglistán ugyan azzal a névvel, illetve lehet ugyan az a felhasználó név több játékosnak egyszerre. Szeretném ha minnél közelebb lenne a játék az eredeti Pac-Man-hez mivel abban több játékoshoz is tartozhatott ugyan az a név, illetve többször is szerepelhetett ugyan az a név a ranglistán különböző pontszámokkal.

**Ekecluded:** A Ranglistán történt változást a program a játékmenet végzésével mentse el az adatbázisban vagy a program bezárása előtt történjen meg?

**Megrendelő:** Szeretném ha a játékmenet befejeztével mentene a program, de csak akkor ha a játékos felkerült a ranglistára. 

**Ekecluded:** Mentés előtt adjunk választási lehetőséget arra, hogy szeretné-e a felhasználó azt, hogy a pontszáma mentésre kerüljön?

**Megrendelő:** Szeretnénk ha ezt a lehetőséget megadná a program a felhasználónak.

**Ekecluded:** A játék végénél található újra kezdés opciót választva a program mentse-e el az elért pontszámot, ha az benne lenne a legjobb tíz pontszámban?

**Megrendelő:** Igen, mindenképp mentse el akkor is a pontszámot, ha a felhasználó az újra kezdés opciót választja.

**Ekecluded:** A Kilépés opció választásával kérdezzen-e rá a program arra hogy a felhasználó ki akar-e lépni?

**Megrendelő:** Igen, kérdezzen rá a program, mivel lehetséges hogy a felhasználó csak félre kattinott, és valójában nem is akart volna kilépni a programból.

**Ekecluded:** Ebben az esetben milyen opciók közül lehessen választani a felhasználónak?

**Megrendelő:** Szeretném ha lenne egy Igen, kiszeretnék lépni opció és egy Vissza a főmenübe opció ami a felhasználót a főmenübe tölti be a program.

**Ekecluded:** köszönjük a riportot. Viszontlátásra!

**Megrendelő:** Viszontlátásra!

# Fogalomszótár
- Namco: Japán játékfejlesztői cég volt az 1980-as években.
- Unity: Vieójáték-motor aminek segítségével háromdimenziós illetve kétdimenziós videójátékokat, ezen kívül egyéb interaktív jellegű tartalmakat lehet létrehozni.
- C Sharp: Programozási nyelv.
- Unity Editor: Fejlesztői környezet.
- Microsoft Visual Studio: Fejlesztői környezet.
- Windows 7/8/10: Operációs rendszer és annak generációi.
- CPU: Processzor
- RAM: Memória
- GPU: Videókártya