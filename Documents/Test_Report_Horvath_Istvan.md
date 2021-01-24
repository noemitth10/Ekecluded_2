# Teszt jegyzőkönyv

# Projekt adatai:
- Projektkód: SJ015FS
- Projektnév: Pac-Man 3d

# Tesztelő adatai:
- Név: Horváth István
- Beosztás: Junior programozó

| Tesztkód | Tesztelt funkció | Teszteset leírása                                                              | Státusz    | Hiba oka                                                         | időpont           |
|----------|------------------|--------------------------------------------------------------------------------|------------|------------------------------------------------------------------|-------------------|
| T01      | Irányítás        | A karakter elkanyarodik jobbra ha fordulóponthoz ér.                           | Sikertelen | Nem megfelelő gombra van a jobbra kanyarodás állítva.            | 2021.01.24. 12:00 |
| T01      | Irányítás        | A karakter elkanyarodik jobbra ha fordulóponthoz ér.                           | Sikertelen | Fordulóponthoz érés feltétele rosszul van megírva.               | 2021.01.24. 12:03 |
| T01      | Irányítás        | A karakter elkanyarodik jobbra ha fordulóponthoz ér.                           | Sikeres    | -                                                                | 2021.01.24. 12:05 |
| T02      | Irányítás        | Ha a karakter előtt fal van megáll és kanyarodási irányt vár a felhasználótól. | Sikertelen | A karakter hamarabb megáll minthogy fordulóponthoz érne.         | 2021.01.24. 12:08 |
| T02      | Irányítás        | Ha a karakter előtt fal van megáll és kanyarodási irányt vár a felhasználótól. | Sikeres    | -                                                                | 2021.01.24. 12:12 |
| T03      | Mechanika        | A kamera követi a karaktert előrehaladás esetén.                               | Sikeres    | -                                                                | 2021.01.24. 12:15 |
| T04      | Mechanika        | Teleport után a kamera a karakterünket követve megjelenik mögötte.             | Sikertelen | A kamera pozíció nem frissül a karakter pozíciójára.             | 2021.01.24. 12:20 |
| T04      | Mechanika        | Teleport után a kamera a karakterünket követve megjelenik mögötte.             | Sikeres    | -                                                                | 2021.01.24. 12:24 |
| T05      | Irányítás        | A karakter falhoz érve nem fordulhat hátra.                                    | Sikeres    | -                                                                | 2021.01.24. 12:28 |
| T06      | Interface        | Az elért pont számláló megfelelően jelenik meg a képernyőn.                    | Sikertelen | Nem jelenik meg a számláló a játék elindítását követően.         | 2021.01.24. 12:31 |
| T06      | Interface        | Az elért pont számláló megfelelően jelenik meg a képernyőn.                    | Sikertelen | Nem megfelelő helyen jelenik meg a számláló.                     | 2021.01.24. 12:35 |
| T06      | Interface        | Az elért pont számláló megfelelően jelenik meg a képernyőn.                    | Sikeres    | -                                                                | 2021.01.24. 12:40 |
| T07      | Mechanika        | Szellemekkel való találkozásnál karakterünk egy életerőt veszít.               | Sikertelen | Karakterünk több életerőt veszíthet egyes esetekben.             | 2021.01.24. 12:50 |
| T08      | Mechanika        | A szellemek nem ütköznek a falakba mozgás közben.                              | Sikeres    | -                                                                | 2021.01.24. 12:56 |
| T09      | Mechanika        | A szellemek fordulóponthoz érve elkanyarodnak balra.                           | Sikeres    | -                                                                | 2021.01.24. 13:05 |
| T10      | Mechanika        | A szellemek fordulóponthoz érve elkanyarodnak jobbra.                          | Sikeres    | -                                                                | 2021.01.24. 13:08 |
| T11      | Mechanika        | A szellemek megfordulnak az elenkező irányba mozgás közben.                    | Sikeres    | -                                                                | 2021.01.24. 13:11 |
| T12      | Interface        | A játék végetértével a Main Menü gombra kattintva vissza irányít a Menübe.     | Sikeres    | -                                                                | 2021.01.24. 13:15 |
| T13      | Interface        | A játék végetértével a Restart gombra kattintva újraindul a játék.             | Sikertelen | A játék újraindul de a karakter nem mozdul kezdeti pozíciójáról. | 2021.01.24. 13:20 |
| T14      | Mechanika        | A szellemek random útvonalon mozognak.                                         | Sikeres    | -                                                                | 2021.01.24. 13:24 |
