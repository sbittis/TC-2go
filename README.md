# TC-2go

TC-2go ist eine Anwendung zur Verwaltung von Teilnehmern auf Jugendfreizeiten. Insbesondere können Teilnehmer, die das Gelände temporär verlassen, ab- und später wieder angemeldet werden. Außerdem können Behandlungen von Sanitätern erfasst und verwaltet werden. Dazu sind Namensschilder für jeden Teilnehmer und Teamer notwendig, die jeweils einen Barcode mit einer eindeutigen ID enthalten, sowie ein Barcode-Scanner, der mit der Anwendung verbunden wird. Zum Erstellen der Barcodes kann die Schriftart [Code39](http://www.logitogo.com/html/barcode39_erstellen.html) verwendet werden. **Es wird empfohlen, das Programm mit einem Touchscreen zu verwenden. Die Bedienung mit einer Maus ist aber auch möglich.**

## Installation
Zur Installation wird die bereitgestellte *setup.exe* aus dem build-Verzeichnis ausgeführt. Über den Install-Wizard wird die Anwendung dann installiert.

## Daten
*In der nächsten Version wird eine Speicherung in einer SQL-Datenbank angestrebt.*
Die Anwendung benötigt die Daten als komma-separierte CSV-Dateien. Diese können zum Beispiel mit Excel erstellt werden (<em>Export als CSV</em>). Die Daten zu verschiedenen Typen werden in jeweils einer Datei gespeichert. Es werden also folgende Dateien benötigt:
* Teilnehmerdaten
* Teamerdaten
* Sanidaten
* Verlaufsdaten

Die jeweiligen Dateien müssen den im folgenden beschriebenen Strukturen *in genannter Reihenfolge* genügen:
### Teilnehmerdaten
Spaltenname | Inhalt | Zu beachten
----------- | ------ | -----------
id | Lfd. Nummer, eindeutige Nummer des Teilnehmers | Zwischen 1000 und 9999
nachname | Nachname des Teilnehmers | Zeichenkette
vorname | Vorname des Teilnehmers | Zeichenkette
gemeinde | Gemeinde des Teilnehmers | Zeichenkette
zeltnr | Zeltnummer des Teilnehmers | ganze Zahl
abwesend | 0 | hier wird später eingetragen, wenn ein Teilnehmer abwesend ist
kommentar | ggf. Kommentar zum Teilnehmer | Zeichenkette

### Teamerdaten
Spaltenname | Inhalt | Zu beachten
----------- | ------ | -----------
id | Lfd. Nummer, eindeutige Nummer des Teilnehmers | Zwischen 100 und 999
nachname | Nachname des Teilnehmers | Zeichenkette
vorname | Vorname des Teilnehmers | Zeichenkette
zeltnr | Zeltnummer des Teilnehmers | ganze Zahl

### Sanidaten
*Hier muss einfach mit dem Windows-Editor eine leere CSV-Datei angelegt werden. Die Struktur wird im folgenden trotzdem beschrieben.*

Spaltenname | Inhalt | Zu beachten
----------- | ------ | -----------
erfasst | Zeitpunkt der Erfassung | formatierter Datumswert
patient | ID des behandelten Patienten | ganze Zahl zwischen 100 und 9999
arzt | ID des behandelnden Sanitäters | ganze Zahl zwischen 100 und 999
text1 | Symptome/Beschwerden des Patienten |Zeichenkette
text2 | durchgeführte Behandlung | Zeichenkette

### Verlaufsdaten
*Hier muss einfach mit dem Windows-Editor eine leere CSV-Datei angelegt werden. Die Struktur wird im folgenden trotzdem beschrieben.*

Spaltenname | Inhalt | Zu beachten
----------- | ------ | -----------
abmeldung | 0 oder 1 | Indikator, ob ein Teilnehmer an- oder abgemeldet wurde.
datum | Datum der An- oder Abmeldung | formatierter Datumswert
zeit | Uhrzeit der An- oder Abmeldung | formatierter Zeitwert
tn | ID des an- oder abgemeldeten Teilnehmers | ganze Zahl zwischen 1000 und 9999
teamer | ID des an- oder abmeldenden Teamers | ganze Zahl zwischen 100 und 999

## Erster Start der Anwendung
Beim ersten Start der Anwendung wird der Benutzer gebeten, die Speicherorte der oben genannten Dateien nacheinander anzugeben.
Der Barcode-Scanner muss so eingestellt werden, dass er wie eine USB-Tastatur funktioniert, den gescannten Code als Zeichenfolge eingibt und die Eingabe mit einem Zeilenumbruch (CRLF) beendet. Zum Einstellen kann die jeweilige Bedienungsanleitung des Scanners hinzugezogen werden.

## Bedienung
### Hauptfenster
Das Hauptfenster zeigt eine Liste der aktuell abgemeldeten Teilnehmer an. Über ein Suchfeld kann in dieser gesucht werden. Über verschiedene Schaltflächen können die Aktionen
* Teilnehmer abmelden
* Teilnehmer anmelden
* Teilnehmerliste anzeigen
* Teamerliste anzeigen
* Zeltliste anzeigen
* Sanifenster öffnen
* Kommentar hinzufügen/bearbeiten
ausgeführt werden. Über das Menü können Einstellungen vorgenommen, der Verlauf eingesehen und CSV-Dateien, aus denen gelesen und in die geschrieben werden sollen, gesetzt werden.

### Ab- und anmelden
Bei Auswahl von "Abmelden" oder "Anmelden" öffnet sich ein Fenster, welches den Benutzer auffordert, die jeweiligen Teilnehmer zu scannen. Gibt es beim Scannen Probleme, kann der Teilnehmer auch manuell aus der Liste gesucht werden (Klick auf "Manuelle Eingabe"). Nachdem alle gewünschten Teilnehmer eingegeben wurden, wird der Dialog mit "Fertig" bestätigt. Dann wird der Teamer aufgefordert, sich selbst zu scannen und zu bestätigen.

### Verlauf
Über das Menü im Hauptfenster kann der Verlauf geöffnet werden. Hier werden alle Ab- und Anmeldungen angezeigt. Es kann über ein Suchfeld gesucht werden oder über die Reiter nach Datum, Ab- und Anmeldungen gefiltert werden.

### Sanifenster
Im Sanifester werden die Behandlungen von Teilnehmern durch Sanitäter verwaltet. Das Sanifenster ist mit einer zweifachen Autorisierung gesichert, da hier sensible Daten hinterlegt werden. Es erfolgt eine Zugriffskontrolle
* mittels eines Passwortes, welches fest im Quellcode gesetzt ist
* mittels einer Autorisierung des Teamers; in einer Textdatei sind die IDs aller Teamer abgelegt, die auf das Sanifenster zugreifen dürfen. Mit dieser wird der aktuelle Teamer abgeglichen. (*Diese Methode bietet keine hohe Sicherheit, weil die Textdatei offen erreichbar ist.*)

### Monitoring
Es gibt eine Funktion, die in regelmäßigen Zeitabständen prüft, ob alle Pfade gesetzt sind und alles korrekt funktioniert. Gibt es ein Problem, wird dieses im Hauptfenster unten rechts in einem kleinen Feld angezeigt.
