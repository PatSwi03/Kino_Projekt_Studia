# Projekt_Kino - prosta aplikacja kina

## Podstawowe informacje

Aplikacja powstała w ramach projektu oraz nauki na zajecia.
Projekt_Kino przedstawia aplikacje z funkcjami dla pracownika kina.
Pracownik chcący skorzystać z aplikacji posiada własne dane logowania, które aplikacja uzyskuje z bazy danych.
Pracownik ma również opcje utworzenie rachunku z wybranymi filmami oraz przekąskami.
Baza danych "Kino" jest również źródłem listy aktualnie dostępnych filmów.
Język w którym została utworzona baza danych to MySql

## Wykorzystana technologia

* C# (główny język projektu)
* Pakiet NuGet MySQL.Client (wymagany pakiet do zainstalowania przy pracy z MySQL)
* MySql (baza danych utworzona w tym języku)
* Xampp (jako środowiko do administracji bazy danych)

## Implementacja
- Wymagania – Wymogiem aplikacji jest wyświetlanie obecnie dostępnych filmów wprowadzonych do bazy danych wraz z możliwością dokonania zakupu przekąsek.
- Projektowanie - Zaczęliśmy tworzenie projektu od dostosowania naszych umiejętności do planu na projekt wraz z dodatkowymi funkcjami, które mogliśmy załączyć do aplikacji.
- Tworzenie – Pierwszą rzeczą jaką wykonaliśmy był panel logowania pracownika, który działa przy pomocy utworzonej bazy MySQL, następnie przystąpiliśmy do tworzenia pośredniego panelu między tworzeniem rachunków a panelem logowania. Panel rachunków, który zawiera listę filmów, przekąsek oraz metody płatności był ostatnim etapem projektu.

## Umiejętności
Podczas tworzenia aplikacji nauczyliśmy się czynności takich jak: 
* Sprawne łączenie bazy danych z aplikacją 
* Tworzenie bazy danych w MySQL 
* Edycja elementów w bazie danych  
* Tworzenia projektu w języku programowania C# w postaci programu okienkowego 
* Pracy ze środowiskiem GitHub

## Jak uruchomić

Do poprawnego działania aplikacji potrzebujemy środowiska w którym będziemy mogli uruchomić baze danych.
W projekcie została wykorzystana aplikacja Xampp do instalacji oraz zarządzania bazą danych.
W aplikacji uruchamiamy usługe SQL, oraz instalujemy baze danych pod nazwa kino.
Nazwa bazy danych jest kluczowa do poprawnego działania aplikacji.
Po uruchomieniu aplikacji ukazuje się nam panel logowania do aplikacji, w którym musimy wprowadzić prawidłowe dane logowania
konto używane w czasie tworzenia aplikacji to Admin WSB.
Po poprawnym zalogowaniu uzyskujemy dostęp do reszty aplikacji.


1. Pobieramy repozytorium
2. Pobieramy aplikacje Xampp oraz uruchamiamy.
3. Wchodzimy w adres http://127.0.0.1/phpmyadmin/
4. Tworzymy nową bazę danych o nazwie "Kino" oraz wybieramy system kodowania "utf8_polish_ci" .            
![Tworzenie bazy](https://github.com/PatSwi03/Kino_Projekt_Studia/assets/148622312/20ce101c-3f5d-49ac-b9a9-6009dab9fece)
5. Wchodzimy do naszej nowo utworzonej bazy oraz klikamy przycisk import.
![import bazy](https://github.com/PatSwi03/Kino_Projekt_Studia/assets/148622312/873dd2c8-3c39-47f0-9cb2-905f20a76724)
6. Wybieramy opcje wybierz plik oraz odszukujemy plik Kino.sql oraz zatwierdzamy.
7. Po wykonaniu tych kroków aplikacja powinna działać bez zastrzeżeń.
=======
2. Wchodzimy w adres http://127.0.0.1/phpmyadmin/
3. Tworzymy nową bazę danych o nazwie Kino.            
![Tworzenie bazy](https://github.com/PatSwi03/Kino_Projekt_Studia/assets/148622312/20ce101c-3f5d-49ac-b9a9-6009dab9fece)
4. Wchodzimy do naszej nowo utworzonej bazy oraz klikamy przycisk import.
![import bazy](https://github.com/PatSwi03/Kino_Projekt_Studia/assets/148622312/873dd2c8-3c39-47f0-9cb2-905f20a76724)
5. Wybieramy opcje wybierz plik oraz odszukujemy plik Kino.sql oraz zatwierdzamy.
6. Po wykonaniu tych kroków aplikacja powinna działać bez zastrzeżeń.

## Elementy aplikacji

* Panel Logowania                                     
![Panel Logowania](https://github.com/PatSwi03/Kino_Projekt_Studia/assets/148622312/fd2a27d3-2d60-4acf-aef9-d9eeb272df3c)

* Okno pośrednie - umożliwiający przejscie pomiędzy tworzeniem paragonów oraz logowaniem
![Okno pośrednie](https://github.com/PatSwi03/Kino_Projekt_Studia/assets/148622312/4b6b073e-3994-4963-9dd9-8894cfb96be2)

* Okno tworzenia paragonów - okno zawiera liste dziś dostępnych filmów, listę dostępnych przekąsek oraz widok lącznej sumy rachunku
![image](https://github.com/PatSwi03/Kino_Projekt_Studia/assets/148622312/cbd87c61-795c-4cef-b043-d2fb5aab83c1)

## Struktura Bazy "Kino"
Baza danych "Kino" - jest prostym źródłem danych dla aplikacji, baza składa się z 2 tabel users oraz filmy.
* Struktura oraz dane wprowadzone do tabeli "users"
![Struktura users](https://github.com/PatSwi03/Kino_Projekt_Studia/assets/148622312/f0e78206-3ceb-477e-9f9f-792860e4d88f)
![Dane users](https://github.com/PatSwi03/Kino_Projekt_Studia/assets/148622312/01ab7193-12f5-41d3-bb8c-02147a825cd2)
* Struktura oraz dane wprowadzone do tabeli "filmy"
![Struktura filmy](https://github.com/PatSwi03/Kino_Projekt_Studia/assets/148622312/a59a9afb-b3e2-4a55-a8aa-c01b62c3cf7d)
![Dane filmy](https://github.com/PatSwi03/Kino_Projekt_Studia/assets/148622312/8625189c-bf04-4f01-abff-074a91419268)

## Zmiana wyszukiwania filmów
W celu zmiany wyszukiwania filmów na filmy, które są w dzisiejszym repertuarze należy zmienić istniejący kod Form3.cs
Należy zmienić wartość string query = "SELECT Tytul, Rezyser, Ocena, Data, Dlugosc FROM `filmy`";
![Obecne wyszukiwanie filmów](https://github.com/PatSwi03/Kino_Projekt_Studia/assets/148622312/ac76da6f-f729-4628-a823-14710b4c97da)            
na string query = "SELECT Tytul, Rezyser, Ocena, Data FROM `filmy` WHERE DATE(data) = CURDATE()"; dla efektu 
![Ograniczone wyświetlanie filmów](https://github.com/PatSwi03/Kino_Projekt_Studia/assets/148622312/ca21edab-63f5-4852-bb93-7a42563ae051)

## Wnioski z wykonanej pracy

1. Podczas tworzenia panelu logowania zastosowaliśmy pierwsze łączenie z bazą danych z której uzyskujemy informacje o danych do zalogowania się do aplikacji, wykorzystaliśmy rówież przejscia pomiędzy częściami programu Form.
2. Przy tworzeniu okna odpowiedzialnego za paragony znów wykorzystaliśmy łączenie z baza tylko tym razem uzyskujemy informacje o filmach, a dokladniej o takich dostępnych w danym dniu.
3. W tym oknie miała również pojawić się opcja zapisywania paragonów do bazy danych. Opcja ta została przez nas porzucona z powodu występujących problemów przy przekazywaniu wartości o typie dokonanej płatności (karta/gotówka).
4. Po konsultacjach w sprawie projektu dodaliśmy kilka podstawowych klas do programu.
