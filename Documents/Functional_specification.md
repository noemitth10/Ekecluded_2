# A rendszer céljai és nem céljai
A rendszer célja a szórakoztatás, amit egy a Unity játékmotor segítségével készült Pac-Man játék fog lehetővé tenni. A játék nem bonyolult, a karaktert egy pályán navigálva kell felvenni érméket, miközben az ellenséget elkerülve vagy Power up segítségével legyőzve navigálunk, ezentúl lehet törekedni a lehető legtöbb pont elérése. Az elért pontszámokat automatikusan elmenti a program, ami később láthathó a toplistán is, tehát a játék egyfajta verseny ként is felfogható. Az összes érme felvétele után az érmék újra megjelennek tehát ekkor a játéknak nincs vége, növelhető tovább a pontszám, a játék akkor ér véget ha a három élet elfogy, ilyenkor új játékba kezdése vagy kilépés a menübe opció közül lehet választani. Nem egy újabb hagyományos 2D Pac-Man-t fog készíteni a csapatunk hanem egy 3D-ben kivitelezett Pac-Man-t fog létrehozni, mivel így minimálisan másabb élményt nyújt a felhasználónak, ezen felül új játék mechanikákkal is bővitve lesz az általunk készített Pac-Man videójáték amik tovább növelhetik a játék élményt.
# Jelenlegi helyzet
A Pac-Man a Namco játéka, amelyet 1980-ban adtak ki a játéktermekbe, és később különféle platformokra. Igazi klasszikussá vált, a világ egyik legismertebb játéka. A játék egy labirintusban játszódik, amelyben egy kis sárga fejet kell irányítani. A cél az, hogy a pontokat megegye, és elkerülje a négy szellem ellenséget, amelyek el akarják kapni Pac-Man-t. Már a bemutatásánál nagyon népszerű játék lett. Ebből adódóan az emberek többsége szívesen játszana egy új, modernebb verzióval, Ezen felül a fiatalabb korosztályok is megismerkedhetnek a Pac-Man fantasztikus világával.
# Vágyálomrendszer
A projekt célja egy 3D Pac-man megvalósítása, amely a felhasználók kikapcsolódását segít elő. Az alkalmazás Windows operációs rendszereken lesz elérhető. Az alkalmazás elindítása után egy színes menü oldal tárul a felhasználó elé, a menü oldalon történő navigáció egszerű a felhasználó élmények javítása érdekében. A menüben egy játék, egy toplista, egy shop és egy beállítások fül elérhető. A játék lehetőséget nyújtani a felhasználók teljesítményének tárolására (toplista), ennek segítségével másokkal is összemérhetik ügyességüket. A játék során elért pontjainkat fel tudják használni a gyüjthető kinézeti elemek megvásárlására, ezek a gyüjthető elemek cserélhetőek, hogy a saját karakterük kinézetét egyedivé tehessék vagy akár más pálya kinézettekkel is játszhassanak. A gyüjthető elemek sapkák különböző arcok és pálya kinézetek, amelyeket a shop-ban lehet megvenni a játékban szerzett pontokból, az értékük eltérő. A pontszámokat egy adatbázisban tárolja a rendszer, amelyben az adatfeltöltés során a játékosok saját nevet adhatnak meg, ideális esetben a felhasználók álltal megadott nevek egyediek lesznek, ezáltal az adatbázisban nem láthatjuk kétszer ugyan azt a nevet. A játék közben különböző power up-okat gyüjtenek mint például a gyorítás vagy akár a ghostokat is meg lehet majd enni ezek segítségével, a pálya ülönböző részein lesznek véletlenül elhelyezve. Pontokat minden megevett coin vagy ghost után fognak kapni a játékosok, a cél az összes pont összegyüjtése a ghostokat elkerülve.