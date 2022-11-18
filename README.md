# Saityno taikomųjų programų projektavimas
# Laboratorinio darbo ataskaita


## _1.	Uždavinio aprašymas_
Turime baldų surinkimo – pardavimo įmonę. Norint supaprastinti siūlomų prekių peržiūrą, užsakymą bei neatsilikti nuo šių laikų įmonei kuriame internetinę svetainę.

Paskirtis:
Pagrindinė kuriamos svetainės (sistemos) paskirtis – leisti užsakovui matyti įmonės surenkamus ir parduodamus baldus. Juos užsisakyti iš karto, arba, pakoregavus baldo sudedamąsias dalis, užsisakyti unikalų baldą.
Toliau sistema, matydama turimų dalių padėtį, bei darbuotojų užimtumą, pirkėjui pasiūlytų numatomą baldų surinkimo laiką bei kainą, priimtų užsakymą ir leistų matyti informaciją apie esamą užsakymo būklę.

Funkciniai reikalavimai:
Neregistruotas sistemos vartotojas (svečias) galės:
-	Patekti į pagrindinį puslapį.
-	Peržiūrėti siūlomus baldus.
-	Prisiregistruoti sistemoje.

Registruotas vartotojas galės:
-	Prisijungti/atsijungti nuo sistemos.
-	Patekti į pagrindinį ir baldų peržiūros puslapius.
-	Kurti „unikalų“ baldą.
-	Iš galimų „standartinių“ ir „unikalių“ baldų susikurti bei patvirtinti užsakymą.
-	Matyti užsakymo(-ų) vykdymo būklę bei numatomą užbaigimo laiką.

Sistemos administratorius galės:
-	Patekti į visus, su vartotojų asmenine informacija nesusijusius, puslapius.
-	Matyti visų registruotų vartotojų sąrašą.
-	Šalinti vartotojus.

## _2.	Naudojamos technologijos_

Kuriama sistema skiriama laboratorinio darbo atlikimui, įmonė – išgalvota. To pasėkoje naudojame nemokamas, bet ne pačias sparčiausias ar saugiausias priemones.

Pačią sistemą skaidome į dvi pagrindines dalis:
-	Frontend – tai, kas yra matoma vartotojui.
-	Backend – visa likusi sistemos veikimui reikalinga dalis.

Frontend‘ui kurti naudojame “.net Blazor WebAssembly“ karkasą. Naudojamos HTML(pagražinimui CSS, Bootstrap) ir C# kalbos.
Backend‘as susideda iš bent dvejų  dalių: API (Application Programming Interface), kurio pagalba „Frontend‘as“ gaus jam reikalingus duomenis. Ir duomenų bazės, kurioje tie duomenys bus saugomi.
Backend‘ą, priklausomai nuo poreikio, galime skirstyti ir į daugiau dalių (turėti atskirą serverį ir API skirtą veiksmams su vartotojų duomenimis; atskirai laikyti vykdomus užsakymus ir t.t.) taip darydami sistemą spartesnę ir atsparesnę gedimams. Bet taip smulkinsimės nebent realaus projekto atveju.
-	Kur ir kaip saugosime Frontend‘ą – nenuspręsta.
-	API dalis saugojama IIS (Internet Information Services) serveryje.
-	Duomenų serveris – MS SQL.

Sistemos architektūra pavaizduota paveikslėlyje pav. 2.1.

![N|Solid](https://drive.google.com/uc?export=view&id=1YAAHpneoCY6VrC6KF0ps1E-b_2FNwhBY)
