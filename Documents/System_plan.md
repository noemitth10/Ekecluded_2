# A rendszer célja
A rendszer célja a szórakoztatás, amit egy a Unity játékmotor segítségével készült Pac-Man játék fog lehetővé tenni. A játék nem bonyolult, a karaktert egy pályán navigálva kell elkerülni az ellenségeket vagy egy Power up segítségével legyőzni azokat, ezenfelül érmék gyűjtögetésével lehet törekedni a lehető legtöbb pont elérése. Az elért pontszámokat a program menti ha a játékos azt az opciót választja a játék végén ezáltal felkerülhet a ranglistára, tehát a játék egyfajta verseny ként is felfogható.
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

