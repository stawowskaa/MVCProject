SYSTEM ZARZĄDZANIA BIBLIOTEKĄ 

Aplikacja internetowa MVC stworzona przy użyciu ASP.NET, która umożliwia zarządzanie książkami oraz śledzenie wypożyczeń w bibliotece. 

 

Spis Treści 

1. Wymagania 

2. Instalacja 

3. Uruchomienie 

4. Instrukcja Użytkowania 

5. Funkcjonalność 

6. Problemy i Rozwiązywanie Problemów 

 

1. Wymagania 

Przed rozpoczęciem, upewnij się, że masz zainstalowane następujące oprogramowanie: 

- Visual Studio 2019 lub nowszy 

- .NET 5.0 lub nowszy 

- SQL Server lub SQL Server Express 

 

2. Instalacja 

Klonowanie Repozytorium:

- Skopiuj repozytorium na swój lokalny komputer: https://github.com/stawowskaa/MVCProject.git 

- Konfiguracja Bazy Danych 

- Otwórz Visual Studio i załaduj projekt. 

- W pliku ApplicationDbContext.cs skonfiguruj połączenie do swojej bazy danych.  

Migracje Bazy Danych:

- Otwórz Konsolę Menedżera Pakietów NuGet(Tools, Package Manager Console) w Visual Studio i uruchom następujące polecenie, aby zastosować migracje i zainicjować bazę danych: Update-Database. 

3. Uruchomienie:

Uruchomienie Aplikacji:

- W Visual Studio, ustaw projekt jako startowy. 

- Naciśnij przycisk "Start" w Visual Studio, aby uruchomić aplikację. 

Dostęp do Aplikacji:

- Aplikacja zostanie uruchomiona w przeglądarce pod adresem http://localhost:5000 lub innym skonfigurowanym portem. 

 

4. Instrukcja Użytkowania 

Dodawanie Nowej Książki:

- Przejdź do sekcji "MyLibrary" w pasku nawigacji. 

- Klikij w przycisk “Create new book”. 

- Wypełnij formularz dodawania nowej książki, podając tytuł i autora. 

- Kliknij "Create", aby dodać książkę do katalogu lub “Back to List”, aby wrócić do listy. 

Modyfikowanie Książki:

- Przejdź do sekcji "MyLibrary" w pasku nawigacji. 

- Kliknij przycisk "Edit" obok książki, którą chcesz zmodyfikować. 

- Wprowadź zmiany w formularzu edycji i kliknij "Save" lub “Back to List”, aby wrócić do listy. 

Usuwanie Książki:

- Przejdź do sekcji "MyLibrary" w pasku nawigacji. 

- Kliknij przycisk "Delete" obok książki, którą chcesz usunąć. 

- Potwierdź usunięcie klikając "Delete” lub “Back to List”, aby wrócić do listy. 

Śledzenie Wypożyczeń:

- Przejdź do sekcji "MyLibrary" w pasku nawigacji. 

- Zobacz kto wypożyczył daną książkę i wyświetla się w sekcji “Reader” oraz kontakt do osoby wypożyczającej i termin zwrotu. 

Wyszukiwanie Książek:

- Przejdź do sekcji "MyLibrary" w pasku nawigacji. 

- Użyj pola wyszukiwania u góry strony, aby znaleźć książki według autora lub tytułu. Wyniki wyszukiwania zostaną wyświetlone poniżej pola wyszukiwania. 

 

5. Funkcjonalność 

- Dodawanie, modyfikowanie i usuwanie książek: Zarządzaj katalogiem książek w bibliotece. 

- Śledzenie wypożyczeń: Monitoruj status wypożyczonych książek, w tym informacje o osobie wypożyczającej i terminie zwrotu. 

- Wyszukiwanie książek: Znajdź książki w katalogu według autora lub tytułu. 

 

6. Problemy i Rozwiązywanie Problemów 

Nie mogę połączyć się z bazą danych: 

- Upewnij się, że SQL Server jest uruchomiony. 

- Sprawdź poprawność ciągu połączenia w pliku ApplicationDbContext.cs. 

Błąd podczas migracji bazy danych: 

- Upewnij się, że pakiety NuGet są zaktualizowane. 

- Spróbuj usunąć folder Migrations i ponownie wygenerować migracje wpisując w konsolę Menedżera Pakietów NuGet: add-migration Init(dowolna nazwa). 

Strona nie ładuje się poprawnie: 

- Sprawdź konsolę przeglądarki pod kątem błędów JavaScript. 

- Upewnij się, że wszystkie zależności front-endowe są załadowane. 

 
