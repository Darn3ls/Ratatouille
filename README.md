# Ratatouille

## Descrizione
**Ratatouille** è una web application sviluppata con Blazor Server che permette agli utenti registrati di condividere, modificare e visualizzare ricette di cucina in maniera semplice e intuitiva.

## Caratteristiche Principali
- **Autenticazione e Registrazione:**
  Utilizzo ASP.NET Core Identity
- **Gestione delle Ricette:**  
  Consente la creazione, modifica, eliminazione e visualizzazione delle ricette.
- **Ricerca e Filtri:**  
  Funzionalità di ricerca per nome, ingredienti e categorie.
- **Espandibilità:**  
  Possibilità futura di aggiungere commenti, voti e notifiche in tempo reale con SignalR.

## Tecnologie
- **Backend:** ASP.NET Core con Blazor Server
- **ORM:** Entity Framework Core (approccio Code-First)
- **Database:** SQL Server
- **Frontend:**  
  Blazor Server con supporto a framework CSS (Bootstrap) per un design responsive.

## Struttura del Progetto
- **Pages:**  
  Contiene le pagine principali (Home, Dettaglio Ricetta, Login, Registrazione, Profilo, ecc.).
- **Components:**  
  Componenti UI riutilizzabili (card, form, navigazione, ecc.).
- **Models:**  
  Definizione delle entità di dominio (Utente, Ricetta, Commento, Categoria, ecc.).
- **Data:**  
  Configurazione di EF Core, DbContext e migrazioni per la gestione del database.
- **Services:**  
  Logica di business e interazione con il database.

## Note
- Il progetto è concepito per partire in maniera semplice, con possibilità di espansioni future (ad esempio, integrazione di notifiche in tempo reale).
- L'interfaccia è progettata per essere web responsive, ottimizzata per l'uso su desktop e dispositivi mobili via browser.

---



