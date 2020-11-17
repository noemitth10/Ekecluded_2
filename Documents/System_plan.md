# A rendszer célja
A rendszer célja a szórakoztatás, amit egy a Unity játékmotor segítségével készült Pac-Man játék fog lehetővé tenni. A játék nem bonyolult, a karaktert egy pályán navigálva kell elkerülni az ellenségeket vagy egy Power up segítségével legyőzni azokat, ezenfelül érmék gyűjtögetésével lehet törekedni a lehető legtöbb pont elérése. Az elért pontszámokat a program menti ha a játékos azt az opciót választja a játék végén ezáltal felkerülhet a ranglistára, tehát a játék egyfajta verseny ként is felfogható.
# Projekt terv
Projekt vezetők: Farkas Balázs, Tóth Noémi, Barkóczi Martin
A projektvezető felelős a projektcélok megvalósulásáért. A projektvezető ritkán vesz részt közvetlenül a projekt végeredményének előállításához szükséges
tevékenységekben, viszont biztosítja a folyamatos előrehaladást, és a különböző résztvevők közötti kölcsönösen hatékony együttműködést annak érdekében,
hogy a projekt sikeres legyen.
Junior programozók: Alexa Kornél, Horvát István, Horváth Gábor
A Junior programozó feladata számítógépes szoftverek (programok) megtervezése és kivitelezése.
## Ütemterv
|Funkció                | Feladat                                              | Prioritás | Becslés | Határidő    |
|:---------------------:|:----------------------------------------------------:|:---------:|:-------:|:-----------:|
|Grafikai elemek        | Karakterek, pálya elemek megtervezése és megalkotása | C         | 36 óra  | 2020.11.31. |
|Felhasználói felület   | Felhasználói felület megtervezése és létrehozása     | B         | 24 óra  | 2020.11.31. |
|Pálya                  | Pálya megtervezése                                   | A         | 12 óra  | 2020.11.31. |
|Irányítás              | Irányítás megtervezése és megvalósítása              | A         | 24 óra  | 2020.11.31. |
|Pontozási rendszer     | Pontozási rendszer megtervezése és megvalósítása     | B         | 12 óra  | 2020.11.31. |
|Random pont generálás  | Random pont generálása képernyőre                    | A         | 6 óra   | 2020.11.31. |
|Ellenség mozgása       | Ellenségek mozgásának megvalósítása                  | A         | 48 óra  | 2020.11.31. |
|Játék mechanikák       | Játékmechanikák megtervezése és létrehozása          | A         | 72 óra  | 2020.11.31. |
|Adatbázis megtervezése | Adatbázis megtervezése és létrehozása                | A         | 48 óra  | 2020.11.31. |
|Adatbázis kapcsolat    | Adatbázis kapcsolat létrehozása a játékban           | A         | 6 óra   | 2020.11.31. |
A: Nagyon fontos
B: Fontos
C: Kevésbé fontos
## Mérföldkövek:
- Rendszer grafikus felületének elkészítése.
- Rendszer mögötti kód elkészítése.
- Rendszerhez szükséges adatbázis megtervezése és kapcsolat létrehozása.
- Dokumentáció megírása.
- Tesztelés/Javítás
# Funckionális terv

## Rendszerszereplők:
- Admin
- Játékos
## Rendszer használati estek és lefutásaik:

### Admin:
- Teljes hozzáférése van a rendszerhez
- A felhasználói adatokat látják, megváltoztathatják
- Felhasználók hozzáadásához, törléséhez van lehetősége
- Adatbázis megtekintése és módosítása (törlés,hozzáadás)
- Alkalmazás elindítása
- Saját adataikat tudják változtatni
- Kilépés a rendszerből
### Játékos:
- Képes az alkalmazás elindítására
- Az adatbázis megtekintésére
- Saját adatai változtatására(felhasználó név)
- Alkalmazáson belüli beállítások változtatására
- Kilépésre
## Menü-hiearchiák:

### Main menü: 
- Játék elindítása
- Felhasználók megtekintése(Admin)
- Adatbázis megtekintése(Ranglista)
- Kilépés

# Fizikai környezet
A megrendelő által igényelt 3D Pac-Man játékot a Unity grafikus motor, illetve a Visual Studio segítségével valósítjuk meg, C# programozási nyelven. A fejlesztéseket Windows 10 operációs rendszeren végezzük, azonban a program több operációs rendszeren is futni fog.
- Unity 2020.1.13
- C# 8.0
- Visual Studio 2019
A rendszernek megfelően kell működnie a következő operációs rendszereken:
- Microsoft Windows 7
- Microsoft Windows 8
- Microsoft Window 10
- macOS

