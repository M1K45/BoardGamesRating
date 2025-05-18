# BoardGamesRating
> Autor: Michał Kaszowski
## Opis zadania 
Zadanie polegało na wykoknaniu aplikacji bazodanowej przy pomocy szablonu `Blazor Web App`. Aplikacja zawiera system logowania, oraz możliwość wprowadzania ocen dla gier planszowych. 

## Wykonane funkcjonalności
Zawarto następujące funkcjonalności: 
- Podstrony do obsługi bazy danych (poprzez `Razor Compontens using Entity Framework (CRUD)`)
- Odnośnik w menu nawigacyjnym do stworzenia nowej gry
- **Możliwość wgrania zjęcia z dysku**

### W widoku `Details`:
- Możliwość dodanej oceny, która jest aktualizowana przez przeliczenie ją z istniejącą oceną (poszerzono o możliwość napisania komentarza do oceny)
- Wyświetlanie obrazka przypisanego do gry

### W widoku `Index`:
- Sortowanie po ocenach oraz po nazwach gier
- Ukrycie części informacji (zdjęcia)
  
