# Projekt-Dokumentation

Sivickas Benas

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 24.08.22      | 0.0.1   | Ich habe ein paar User-Stories erstellt |
| 01.09.22      | 0.0.2     | Ich habe mit dem Programmieren des Projektes angefangen                                                             |
|08.09.22  | 0.0.3   | Ich bin beim Programmieren des Projektes weitergekommen                                                             |
|08.09.22  | 0.0.4   | Ich habe das Projekt fertigprogrammiert                                                       |

## 1 Informieren

### 1.1 Ihr Projekt

Wir programmieren ein Ratespiel

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |  Muss           |Funktional| Als ein Spieler möchte ich, dass das Programm eine Geheimzahl einspeichert |
| 2    |  Muss           |Funktional          | Als ein Spieler möchte ich eine Zahl erraten, damit ich ein Feedback bekomme |
| 3   |  Muss           |Funktional         | Als ein Spieler möchte ich dass das Programm mir sagt, ob es grösser ist, damit ich weiss welche Zahl ich nachher rate |
| 4  |  Muss           |Funktional         | Als ein Spieler möchte ich dass das Programm mir sagt, ob es kleiner ist, damit ich weiss welche Zahl ich nachher rate |
| 5    |  Kann           |Funktional         | Als ein Spieler möchte ich dass das Programm mir sagt, ob es richtig ist, damit ich weiss, ob ich gewonnen habe |
| 6    |  Kann           |Qualität         | Als ein Spieler möchte ich dass das Programm mir sagt, wie viele Rateversuche ich habe, damit ich weiss wie schlecht ich in diesem spiel bin |
| 7    |  Muss           |Funktional          | Als ein Spieler möchte ich, dass das Programm mir bescheid gibt, falls ich einen Fehler geraten habe |
| 8    |  Kann           |Qualität         | Als Spieler möchte ich, dass das Programm mir sagt, ob ich verloren habe, damit ich weiss, dass ich nächstes Mal besser sein soll |
| 9    |Kann           |Qualität         | Als ein Spieler möchte ich, dass es mehrere Spielmodi gibt, damit mir das Spiel nicht langweilig wird |
| 10    |Kann           |Qualität         | Als ein Spieler möchte ich, dass es einen custom-modus gibt, damit ich meine eigene Maximalzahl eingebe |
| 11    |Kann           |Qualität         | Als ein Spieler möchte ich, dass der Text in Farbe angezeigt wird, damit das Programm schön aussieht |

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Ich starte das Programm| Ich mache nichts | Das Programm speichert eine Geheimzahl ein|
| 2.1  | Ich starte das Programm| Ich schreibe eine Zahl | Das Programm sagt mir ein Feedback|
| 3.1  | Ich starte das Programm| Ich schreibe eine Zahl | Das Programm sagt, dass es zu gross ist|
| 4.1  | Ich starte das Programm| Ich schreibe eine Zahl | Das Programm sagt, dass es zu klein ist|
| 5.1  | Ich starte das Programm| Ich errate die richtige Zahl | Das Programm sagt, dass ich gewonnen habe|
| 6.1  | Ich gewinne| Ich mach nichts | Das Programm sagt, wie viele Versuche ich hatte|
| 7.1  | Ich starte das Programm| Ich schreibe eine Zahl über dem Limit | Das Programm sagt, dass es eine falsche Eingabe ist|
| 7.2  | Ich starte das Programm| Ich schreibe ein Wort | Das Programm sagt, dass es eine falsche Eingabe ist|
| 8.1  | Ich starte das Programm| Ich rate zu viele Male | Das Programm sagt, dass ich verloren habe|
| 9.1    |Ich starte das Programm  |Ich wähle Mega Easy-Mode aus        | Das Programm sagt, dass ich nun von 1-10 rate |
| 9.2    |Ich starte das Programm  |Ich wähle Easy-Mode aus        | Das Programm sagt, dass ich nun von 1-100 rate |
| 9.3    |Ich starte das Programm  |Ich wähle Normal-Mode aus        | Das Programm sagt, dass ich nun von 1-1000 rate |
| 9.4    |Ich starte das Programm  |Ich wähle Hard-Mode aus        | Das Programm sagt, dass ich nun von 1-10000 rate |
| 9.5    |Ich starte das Programm  |Ich wähle Extreme-Mode aus        | Das Programm sagt, dass ich nun von 1-100000 rate |
| 9.6    |Ich starte das Programm  |Ich wähle Impossible-Mode aus        | Das Programm sagt, dass ich nun von 1-1000000 rate |
| 10.1    |Ich starte das Programm  |Ich wähle Custom-Mode aus        | Das Programm sagt, dass ich die Maximalzahl eintippen darf |
| 10.2    |Ich starte den Custom-Mode  |Ich schreibe eine Zahl        | Das Programm sagt, dass ich eine Zahl von 1 bis Maximalzahl raten darf |
| 10.3    |Ich starte den Custom-Mode  |Ich schreibe eine Zahl        | Ich kann die Geheimzahl erraten wie normal erraten |
| 11.1    |Ich starte das Programm  |Ich mache nichts        | Das Programm schreibt den Text in Farbe |

### 1.4 Diagramme

[Program.zip](https://github.com/Zerophyx000/LA_1100/files/9623154/Program.zip)

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung              | geplante Zeit |
| ---- | ----- | --------- | --------------------------| ------------- |
| ---- | ----- | --------- | --------------------------| ----------------- |
| 1.A  |1.9.22 | Benas     | Projektdokumentation verbessern             |    45 Minuten     |
| 1.B  |1.9.22 | Benas     | Programm erstellt geheimzahl                      |    15 Minuten            |
| 1.C  |1.9.22 | Benas     | Man kann eine Zahl raten                      |    45 Minuten            |
| 1.D  |1.9.22 | Benas     | Man bekommt Feedback                      |    45 Minuten            |
| 1.E  |1.9.22 | Benas     | Man kann gewinnen                      |    30 Minuten            |
| 2.A  |8.9.22 | Benas     | Wort eintippen ergibt fehler                |    2x 45 Minuten            |
| 2.B  |8.9.22 | Benas     | Man kann verlieren                    |    2x 45 Minuten            |
| 3.A  |15.9.22 | Benas     | 2.B fertigmachen                   |    45 Minuten            |
| 3.B  |15.9.22 | Benas     | Spielmodi dazutun                  |    2x 45 Minuten            |
| 3.C  |15.9.22 | Benas     | ASCII text, Farbiger Text...                  |    N\A Minuten   (Zusatzarbeit wenn fertig)         |

Total: 

## 3 Entscheiden

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |1.9.22 | Benas     | 45 Minuten    |  45 Minuten                 |
| 1.B  |1.9.22 | Benas     | 15 Minuten    |  10 Minuten                 |
| 1.C  |1.9.22 | Benas     | 45 Minuten    |  45 Minuten                 |
| 1.D  |1.9.22 | Benas     | 45 Minuten    |  30 Minuten                 |
| 1.E  |1.9.22 | Benas     | 30 Minuten    |  15 Minuten                 |
| 2.A  |8.9.22 | Benas     | 90 Minuten    |  120 Minuten                 |
| 2.B  |8.9.22 | Benas     | 90 Minuten    |  nicht erreicht                 |
| 3.A  |15.9.22 | Benas     | 45 Minuten    |  30 Minuten                 |
| 3.B  |15.9.22 | Benas     | 90 Minuten    |  120 Minuten                 |
| 3.C  |15.9.22 | Benas     | 45 Minuten    |  25 Minuten                 |



## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  | 22.09.22| funktioniert | Benas |
| 2.1  | 22.09.22| funktioniert | Benas |
| 3.1  | 22.09.22| funktioniert | Benas |
| 4.1  | 22.09.22| funktioniert | Benas |
| 5.1  | 22.09.22| funktioniert | Benas |
| 6.1  | 22.09.22| funktioniert | Benas |
| 7.1  | 22.09.22| funktioniert | Benas |
| 7.2  | 22.09.22| funktioniert | Benas |
| 8.1  | 22.09.22| funktioniert | Benas |
| 9.1  |22.09.22  |funktioniert| Benas |
| 9.2  |22.09.22  |funktioniert| Benas |
| 9.3  |22.09.22  |funktioniert| Benas |
| 9.4  |22.09.22  |funktioniert| Benas |
| 9.5  |22.09.22  |funktioniert| Benas |
| 9.6  |22.09.22  |funktioniert| Benas |
| 10.1  |22.09.22  |funktioniert| Benas |
| 10.2  |22.09.22  |funktioniert| Benas |
| 10.3  |22.09.22  |funktioniert| Benas |
| 11.1  |22.09.22  |funktioniert| Benas |



### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |


## 6 Auswerten

