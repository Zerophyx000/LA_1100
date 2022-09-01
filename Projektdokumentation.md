# Projekt-Dokumentation

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

✍️ Ihr Gruppenname und Ihre Nachnamen

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

✍️ Beschreiben Sie Ihr Projekt in einem griffigen Satz.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |  Muss           |      | Als ein Spieler möchte ich eine Zahl errate, damit ich gewinne und mich glücklich fühle |
| 2    |  Muss           |      | Als ein Spieler möchte ich, dass das Programm eine Zahl generiert, damit ich sie erraten kann |
| 3    |  Kann           |      | Als ein Spieler möchte ich dass das Programm mir sagt, ob es grösser ist, damit ich weiss welche Zahl ich nachher rate |
| 4    |  Muss           |      | Als ein Spieler möchte ich, dass ich ein Zahl eingeben kann, damit ich ein Feedback bekomme |

✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Er kann die Zahl nicht raten| Ich starte das Programm neu | Es funktioniert wieder|
| 2.1  | Das Programm weiss nicht, was grösser oder tiefer ist | Ich repariere die Stelle        | Es funktioniert wieder.                  |
| 3.1  | Das Programm öffnet und funktioniert einwandfrei| Ich mache nichts | Es funktioniert immer noch|
| 4.1  | Er kann die Zahl nicht raten| Ich starte das Programm neu | Es funktioniert immer noch nicht|
| 4.2  | Er kann die Zahl nicht raten| Ich programmiere die Stelle neu | Es funktioniert wieder|

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

[Hier](https://github.com/Zerophyx000/Projektdokumentation/files/9423129/Ratselspiel.zip) ist der Link zum **Rätselspiel**


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung              | geplante Zeit |
| ---- | ----- | --------- | --------------------------| ------------- |
| ---- | ----- | --------- | --------------------------| ----------------- |
| 1.A  |1.9.22 | Benas     | Programmieren             |    60 Minuten     |
| 2.A  |3.9.22 | Benas     | Entscheidungen treffen    |    20 Minuten     |
| 3.A  |4.9.22 | Benas     | Programmieren             |    45 Minuten     |
| 3.B  |7.9.22 | Benas     | Programmieren             |    120 Minuten    |
| 3.C  |10.9.22| Benas     | Programmieren             |    180 Minuten    |
| 4.A  |12.9.22| Benas     | Verfeinern                |    60 Minuten     |
| 5.A  |15.9.22| Benas     | Testen                    |    40 Minuten     |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |1.9.22 | Benas     | 60 Minuten    |    75 Minuten     |
| 2.A  |3.9.22 | Benas     | 20 Minuten    |    30 Minuten     |
| 3.A  |4.9.22 | Benas     | 45 Minuten    |    30 Minuten     |
| 3.B  |7.9.22 | Benas     | 120 Minuten   |    100 Minuten    |
| 3.C  |10.9.22| Benas     | 180 Minuten   |    150 Minuten    |
| 4.A  |12.9.22| Benas     | 60 Minuten    |    60 Minuten     |
| 5.A  |15.9.22| Benas     | 40 Minuten    |    45 Minuten     |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
