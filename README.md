existing user - pass

admin - admin

user - user

user2 - user2


to change:

ugly routes and static class for settings (quick fixes for hosting problems)

infinite loading animation when admin is checking all users table (requirement for lab)

in register window it should say register, not login... (copy paste, forgot to change html)


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

![Kriu](https://drive.google.com/uc?export=view&id=1YAAHpneoCY6VrC6KF0ps1E-b_2FNwhBY)

## _3. Naudotojo sąsajos langai_
Puslapis pasiekiamas adresu:
https://bsite.net/rolkaa114/
Dėl nemokamam puslapio publikavimui keliamų reikalavimų puslapis veiks iki 2023-03-06 dienos. Arba nustos veikti kai API puslapis visą mėnesį nesulauks nė vienos užklausos.
Puslapio lankytojai, naudojantys interneto naršyklę gali patekti į šiuos puslapius:
### _3.1 Neprisijungęs vartotojas_
-	Pagrindinį puslapį.
-	Sumažintą pagrindinio puslapio variantą. Funkcionalumas tas pats, tik šalutiniame meniu esantis prisijungimo / atsijungimo mygtukai persikelia į pagrindinį meniu.
-	Prisijungimo langą. Iš kurio taip pat gali patekti į registracijos langą. Registracijos langas praktiškai identiškas prisijungimo langui, prisideda tik slaptažodžio pakartojimui skirtas laukas.
![Kriu](https://drive.google.com/uc?export=view&id=1XPTPaO-X1cBxIGxKdfSOULYlFH8c6IIV)
![Kriu](https://drive.google.com/uc?export=view&id=1ZHM4g3a8KAls-zvsDV8URyWZDps1c3SJ)
![Kriu](https://drive.google.com/uc?export=view&id=1ZbWFKEQAw4OpWKDevxmhQDUdd1vZ3ATq)

### _3.2 Prisijungęs vartotojas_
Gali patekti į tuos pačius puslapius kaip ir neprisijungęs vartotojas (išskyrus prisijungimą, registraciją) ir į šiuos puslapius:
-	Savo užsakymų sąrašo langą.
-	Naujo užsakymo sukūrimo langą.
-	Užsakymo redagavimo langą.
-	Užsakymą sudarančių baldų sąrašą.
-   Baldo sudėties langą.

![Kriu](https://drive.google.com/uc?export=view&id=1k_7S2p6HJPXSUSoTKHvcczlTwdYd6Qsm)
![Kriu](https://drive.google.com/uc?export=view&id=1gwwqx8wt2ZgEKbMR2l6t2uZ3c-xsiLRx)
![Kriu](https://drive.google.com/uc?export=view&id=1quiv9gSNzCnPwJxZ4tcjI1YR5WohjK4Q)
![Kriu](https://drive.google.com/uc?export=view&id=1cLdqWxbkAqVSygqGJydhdUsVQTM7MJJu)
![Kriu](https://drive.google.com/uc?export=view&id=12IKwQJJRuuGcOUn6y4Op27pFj0vw9Icu)
### _3.3 Administratorius_
Administratorius gali patekti į:
-	Tuos pačius puslapius kaip ir prisijungęs vartotojas, tačiau administratorius lentelėse mato papildomą informacija (užsakymo savininko id, sukūrimo data ir  t.t.). Administratoriui skirtas variantas matomas paveikslėlyje.
-	Vartotojų sąrašo puslapį. Praktiškai identiškai gali atlikti CRUD veiksmus kaip ir su kitais duomenimis. Tiesa tokios dirbtinės vartotojo registracijos reikėtų vengti, nes nėra sukuriami jokie „default“ slaptažodžiai, ko pasėkoje taip sukurta vartotojo paskyra yra praktiškai neįmanoma naudoti. Amžina „loader“ animacija tik parodymui, kad veikia (tam, kad nereikėtų keisti interneto greičio ir t.t. ieškant kur animacija iš tikro matoma).

![Kriu](https://drive.google.com/uc?export=view&id=1H77_nAerP6Y4MijubUlwq4HkrzLDplnI)
![Kriu](https://drive.google.com/uc?export=view&id=1JtPCrJprp7_4Zsi2fUPk7ngGEt3flenl)

## _1.	API specifikacija_
Naudojantis „Twitter“ API aprašymo pavyzdžiu Aprašomi API metodai
### _4.1	Auth API calls_
##### Resource URL:
https://saitynopsl.somee.com/api/auth/register

##### Response Code:
200 - Ok
404 – Already Exists

##### Example Request
POST https://saitynopsl.somee.com/api/auth/register

##### Example Response
{
  "username": "user3",
  "message": "Successfully registered"
}

##### Resource URL:
https://saitynopsl.somee.com/api/auth/login

Response Code:
200 - Ok
404 – Not found, incorrect password.

##### Example Request
POST https://saitynopsl.somee.com/api/auth/login

##### Example Response
{
  "token": " eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoidXNlciIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6IlJlZ2lzdGVyZWRVc2VyIiwiaWQiOiIxIiwiZXhwIjoxNjcxNjUzNDg3fQ.Uzr8GwkluG5HApczpWOuT9ev5rydO-AUR87K3wYulA2UP5BYNIGBZHQ_PywODhtox2UuPI9NML2JE0KPQZydJQ
",
}

### _4.2	Users API calls_
Resource URL:
https://saitynopsl.somee.com/api/users

##### Response Code:
200 – Ok
401 – Unauthorized
403 – Forbidden
404 – Not found

##### Example Request
GET https://saitynopsl.somee.com/api/users

##### Example Response
[
  {
    "id": 1,
    "username": "user",
    "passwordHash": "wEmIJ9KUl5rRCf7Sa/5I3WRYhUVkmaq9sdyfWv7oN+au9HOEt7Tu6/7aR2VJFcRVr84p9kHviTK5boSfCXs+8Q==",
    "passwordSalt": "+rgcQfah/KD2h4dbVQKJ+VlmjsnjLredH1y8Um5UzpAMdAXprWqJkhLm1KhgcoEHFu+sABnKPEAAAoQzmsJ1mGAGgYYhFFUDDWqK1m8exFUCeyBbtarld5SvRou2ejFUH0VDIBLmvyA86dLZqqlQ3s9q76h3CzJqWPCx/WtwBqQ=",
    "dateCreated": "2022-11-16T21:01:43.8170286",
    "isDeleted": false,
    "role": "RegisteredUser"
  },
  {
    "id": 2,
    "username": "admin",
    "passwordHash": "VUXfGeuGF4qO72OV0T06kfhDNCDP55R25LaOA7+/DWSSjdnl//G87OoIBGvl787GYWn2xx5Wwp2lOELgaVug4w==",
    "passwordSalt": "dekwrt5qOlUm/EW8lbNkM+wJGXDCrj9CTFDbcsS5huv/XSxrWQvq6+Kf+Zw5CVBMF1rT44Bmc1TVLcaSwLSf4aj9uGLMchJIuHALp6Yr1802+7XRGx4QuvlpP3kQuu9/fUtbazue8dDGLZMtcJksUata0piHt/wPaT0PWlhcV/4=",
    "dateCreated": "2022-11-16T21:02:39.3830861",
    "isDeleted": false,
    "role": "Admin"
  },
  {
    "id": 3,
    "username": "user2",
    "passwordHash": "u/6uaUb0Us2nWOIJjL8DBKWtQEiy1BYvNfdKRJFpqveE90bZUOZOgFh/9I7y+scdBWca4fL6SpF+C4fLyd/jag==",
    "passwordSalt": "0Leow2IjGi2sxWWm+fAGE0FwhGB3UOlIJGDQDpPryJIFZ7xVQEmj+8yiM4gMHHKSHcF0lJtn+6n/9CwkXy+hIo3c9Ef5Q7nVAB+NmN2WN+J1wyicEOwr3SamVZhk7sY5a0BCbFOQgJ6+kJtRoi1E78UEOpBNWMa3dTf0M4CIG4o=",
    "dateCreated": "2022-11-17T14:37:23.7667756",
    "isDeleted": false,
    "role": "RegisteredUser"
  },
  {
    "id": 4,
    "username": "string",
    "passwordHash": "8M+g3GDbwYliZ+WyYt7d7nP8UAxnudXXHzK6albr/8OueLEoEeFENyjEdHsGbNZ5baKLSbHfA3lYJOOtQXpheg==",
    "passwordSalt": "HwyHrsejSoavpHP2b5V6nrnywtpXKHXDqhuCGYME5egS8F5FLpU31Mt5phBedC0ghjk5lF71towtG7O1t/3L6l5cd9fLJ+FLpSTjHvEgXrOpw+4tJDTl1kdsxV92GBNi0VZp6elmUlrcpSTf5bQs7azZbrch8RkzEXxd+dTJARc=",
    "dateCreated": "2022-12-21T20:47:27.8402824",
    "isDeleted": false,
    "role": "RegisteredUser"
  },
  {
    "id": 5,
    "username": "stringgggg",
    "passwordHash": "AGFIkXa6Z4sOEH1evesn+L+n2+TbAM0JbGaWxf42Zfi5/97WEhiZknuTiD/sFVQ+X8jpjvCs1ifhI+wVDg6i6A==",
    "passwordSalt": "Nmcr35bjAUI3m7eieLHyxOB96hzbR95+iPx813q1bWvO/M4jZiAK4HfkXVD6CxOsF00UYE61NgQoXQPr9dxdBwC/pgzayhebe89/xTgVYIJm4/8kc/va2P0IlwAMbUJOCwStCmuFhpLwC7kcd3jXHUPebSz0GgNnU1JIEZmdV1U=",
    "dateCreated": "2022-12-21T21:10:47.9924186",
    "isDeleted": false,
    "role": "RegisteredUser"
  }
]
##### Resource URL:
https://saitynopsl.somee.com/api/users

##### Response Code:
200 – Ok
400 – Validation Error
401 – Unauthorized
403 – Forbidden
404 – Not found

##### Example Request
POST https://saitynopsl.somee.com/api/users

##### Example Response
{
  "type": "https://tools.ietf.org/html/rfc7231#section-6.5.1",
  "title": "One or more validation errors occurred.",
  "status": 400,
  "traceId": "00-05a5a4cc22e24ba9c5ce89e55f659f50-e5a849c602c21662-00",
  "errors": {
    "user": [
      "The user field is required."
    ],
    "$.passwordHash": [
      "The JSON value could not be converted to System.Byte[]. Path: $.passwordHash | LineNumber: 3 | BytePositionInLine: 26."
    ]
  }

##### Resource URL:
https://saitynopsl.somee.com/api/users/:id

##### Response Code:
201 – Created
401 – Unauthorized
403 – Forbidden
404 – Not found

##### Example Request

GET https://saitynopsl.somee.com/api/users/:id


##### Example Response
{
  "id": 1,
  "username": "user",
  "passwordHash": "wEmIJ9KUl5rRCf7Sa/5I3WRYhUVkmaq9sdyfWv7oN+au9HOEt7Tu6/7aR2VJFcRVr84p9kHviTK5boSfCXs+8Q==",
  "passwordSalt": "+rgcQfah/KD2h4dbVQKJ+VlmjsnjLredH1y8Um5UzpAMdAXprWqJkhLm1KhgcoEHFu+sABnKPEAAAoQzmsJ1mGAGgYYhFFUDDWqK1m8exFUCeyBbtarld5SvRou2ejFUH0VDIBLmvyA86dLZqqlQ3s9q76h3CzJqWPCx/WtwBqQ=",
  "dateCreated": "2022-11-16T21:01:43.8170286",
  "isDeleted": false,
  "role": "RegisteredUser"
}

##### Resource URL:
https://saitynopsl.somee.com/api/users/:id

##### Response Code:
200 – Ok
401 – Unauthorized
403 – Forbidden
404 – Not found

##### Example Request
PUT https://saitynopsl.somee.com/api/users/:id


##### Example Response
{
  "id": 1,
  "username": "user5",
  "passwordHash": "wEmIJ9KUl5rRCf7Sa/5I3WRYhUVkmaq9sdyfWv7oN+au9HOEt7Tu6/7aR2VJFcRVr84p9kHviTK5boSfCXs+8Q==",
  "passwordSalt": "+rgcQfah/KD2h4dbVQKJ+VlmjsnjLredH1y8Um5UzpAMdAXprWqJkhLm1KhgcoEHFu+sABnKPEAAAoQzmsJ1mGAGgYYhFFUDDWqK1m8exFUCeyBbtarld5SvRou2ejFUH0VDIBLmvyA86dLZqqlQ3s9q76h3CzJqWPCx/WtwBqQ=",
  "dateCreated": "2022-11-16T21:01:43.8170286",
  "isDeleted": false,
  "role": "string"
}

##### Resource URL:
https://saitynopsl.somee.com/api/users/:id

##### Response Code:
200 – Ok
401 – Unauthorized
403 – Forbidden
404 – Not found

##### Example Request

DELETE https://saitynopsl.somee.com/api/users/:id

##### Example Response

{
  "id": 3,
  "username": "user2",
  "passwordHash": "u/6uaUb0Us2nWOIJjL8DBKWtQEiy1BYvNfdKRJFpqveE90bZUOZOgFh/9I7y+scdBWca4fL6SpF+C4fLyd/jag==",
  "passwordSalt": "0Leow2IjGi2sxWWm+fAGE0FwhGB3UOlIJGDQDpPryJIFZ7xVQEmj+8yiM4gMHHKSHcF0lJtn+6n/9CwkXy+hIo3c9Ef5Q7nVAB+NmN2WN+J1wyicEOwr3SamVZhk7sY5a0BCbFOQgJ6+kJtRoi1E78UEOpBNWMa3dTf0M4CIG4o=",
  "dateCreated": "2022-11-17T14:37:23.7667756",
  "isDeleted": false,
  "role": "RegisteredUser"
}
### _4.3	Orders API calls_
##### Resource URL:
https://saitynopsl.somee.com/api/orders

##### Response Code:
200 – Ok
404 – Not found

##### Example Request

GET https://saitynopsl.somee.com/api/orders

##### Example Response
[
  {
    "id": 1,
    "buyerId": 1,
    "email": "cclaire0@cloudflare.com",
    "phoneNumber": "+55 575 366 5029",
    "dateCreated": "2022-11-16T20:55:35.2054273",
    "isCompleted": false
  },
  {
    "id": 2,
    "buyerId": 1,
    "email": "odagleas1@desdev.cn",
    "phoneNumber": "+55 126 791 9151",
    "dateCreated": "2022-11-16T20:55:35.2054307",
    "isCompleted": false
  },
  {
    "id": 13,
    "buyerId": 3,
    "email": "pastas@pastauskas.com",
    "phoneNumber": "123456",
    "dateCreated": "2022-11-17T15:40:55.8454717",
    "isCompleted": false
  }
]

##### Resource URL:
https://saitynopsl.somee.com/api/orders

##### Response Code:
200 – Ok
404 – Not found

##### Example Request

POST https://saitynopsl.somee.com/api/orders

##### Example Response
{
  "id": 14,
  "buyerId": 0,
  "email": "string",
  "phoneNumber": "string",
  "dateCreated": "2022-12-21T21:33:33.0226508+02:00",
  "isCompleted": true
}

##### Resource URL:
https://saitynopsl.somee.com/api/ orders/:id

##### Response Code:
201 – Created
404 – Not found

##### Example Request
GET https://saitynopsl.somee.com/api/ orders/:id

##### Example Response
	{
  "id": 1,
  "buyerId": 1,
  "email": "cclaire0@cloudflare.com",
  "phoneNumber": "+55 575 366 5029",
  "dateCreated": "2022-11-16T20:55:35.2054273",
  "isCompleted": false
}

##### Resource URL:
https://saitynopsl.somee.com/api/ orders/:id

##### Response Code:
200 – Ok
404 – Not found

##### Example Request

PUT https://saitynopsl.somee.com/api/ orders/:id

##### Example Response
{
  "id": 1,
  "buyerId": 1,
  "email": "string",
  "phoneNumber": "5555555",
  "dateCreated": "2022-11-16T20:55:35.2054273",
  "isCompleted": true
}

##### Resource URL:
https://saitynopsl.somee.com/api/ orders/:id

##### Response Code:
200 – Ok
404 – Not found

##### Example Request
DELETE https://saitynopsl.somee.com/api/ orders/:id

##### Example Response
{
  "id": 1,
  "buyerId": 1,
  "email": "string",
  "phoneNumber": "5555555",
  "dateCreated": "2022-11-16T20:55:35.2054273",
  "isCompleted": true
}
### _4.4	Furniture API calls_
##### Resource URL:
https://saitynopsl.somee.com/api/orders/:orderId/furniture

##### Response Code:
200 – Ok
404 – Not found

##### Example Request
GET https://saitynopsl.somee.com/api/orders/:orderId/furniture

##### Example Response
[
  {
    "id": 4,
    "orderId": 2,
    "name": "Stalas v2",
    "imageUrl": "https://p.turbosquid.com/ts-thumb/PP/2eYUS5/pY48APl0/logo/png/1580766180/1920x1080/fit_q99/cc21a59fb6ea56d96cb2519aa6261ba5d3b724a0/logo.jpg",
    "toAssemble": true
  }
]

##### Resource URL:
https://saitynopsl.somee.com/api/orders/:orderId/furniture

##### Response Code:
200 – Ok
404 – Not found

##### Example Request
POST https://saitynopsl.somee.com/api/orders/:orderId/furniture

##### Example Response
{
  "id": 16,
  "orderId": 2,
  "name": "string",
  "imageUrl": "string",
  "toAssemble": true
}

##### Resource URL:
https://saitynopsl.somee.com/api/orders/:orderId/furniture:furnitureId

##### Response Code:
201 – Created
404 – Not found

##### Example Request
GET https://saitynopsl.somee.com/api/orders/:orderId/furniture:furnitureId

##### Example Response
{
  "message": "Furniture not found"
}

##### Resource URL:
https://saitynopsl.somee.com/api/orders/:orderId/furniture:furnitureId

##### Response Code:
200 – Ok
404 – Not found

##### Example Request
PUT https://saitynopsl.somee.com/api/orders/:orderId/furniture:furnitureId

##### Example Response
{
  "message": "Order or furniture not found"
}

##### Resource URL:
https://saitynopsl.somee.com/api/orders/:orderId/furniture:furnitureId

##### Response Code:
200 – Ok
404 – Not found

##### Example Request
DELETE https://saitynopsl.somee.com/api/orders/:orderId/furniture:furnitureId

##### Example Response
{
  "message": "Order or furniture not found"
}

### _4.5	Parts API calls_
##### Resource URL:
https://saitynopsl.somee.com/api/orders/:orderId/furniture:furnitureId/parts

##### Response Code:
200 – Ok
404 – Not found

##### Example Request
GET https://saitynopsl.somee.com/api/orders/:orderId/furniture:furnitureId/parts

##### Example Response
{
  "message": "Bad id provided or nothing found"
}


##### Resource URL:
https://saitynopsl.somee.com/api/orders/:orderId/furniture:furnitureId/parts

##### Response Code:
200 – Ok
404 – Not found

##### Example Request
POST https://saitynopsl.somee.com/api/orders/:orderId/furniture:furnitureId/parts

##### Example Response


##### Resource URL:
https://saitynopsl.somee.com/api/orders/:orderId/furniture:furnitureId/parts/{partId}

##### Response Code:
201 – Created
404 – Not found

##### Example Request
GET https://saitynopsl.somee.com/api/orders/:orderId/furniture:furnitureId/parts/{partId}

##### Example Response
{
  "message": "Part was not created"
}

##### Resource URL:
https://saitynopsl.somee.com/api/orders/:orderId/furniture:furnitureId/parts/{partId}

##### Response Code:
200 – Ok
404 – Not found

##### Example Request
PUT https://saitynopsl.somee.com/api/orders/:orderId/furniture:furnitureId/parts/{partId}

##### Example Response
{
  "message": "Bad id provided or nothing found"
}

##### Resource URL:
https://saitynopsl.somee.com/api/orders/:orderId/furniture:furnitureId/parts/{partId}

##### Response Code:
200 – Ok
404 – Not found

##### Example Request
DELETE https://saitynopsl.somee.com/api/orders/:orderId/furniture:furnitureId/parts/{partId}

##### Example Response
{
  "message": "Bad id provided or nothing found"
}
## _5.Išvados_
Laboratorinio darbo eigoje sužinota kas iš viso yra API, kur, kaip naudoti ir t.t.
Susipažinta su įvairiais frontend‘o kūrimo būdais.
Išbandytas bendravimas tarp backend‘o ir frontend‘o, išmokta sekti veiksmus, rasti klaidas naršyklės pagalba.
Sužinota, kad sausainiai (Cookies) yra praeito amžiaus palikimas, ir šiais laikais reikėtų naudoti „Local Storage“.

## _6.Šaltiniai, nuorodos_
Projekto kodo repozitorijos (github) nuoroda:
https://github.com/Appci11/SaitynoLab

Projekto puslapio nuoroda:
https://bsite.net/rolkaa114/

Projekto talpinimui internete:
https://somee.com/
https://freeasphosting.net/
