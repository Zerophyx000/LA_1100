# Lern-Bericht
Benas Sivickas
## Einleitung

Wir haben im Informatikunterricht in Lernatelier ein Ratespiel programmiert

## Was habe ich gelernt?

Ich habe gelernt, wie ich farbigen Text in der C# Konsole schreibe

## Beschreibung
Ich habe in den folgenden Wochen viel gelernt, doch eines konnte ich auf der Konsole noch nicht : farbigen Text schreiben.
Denn die Konsole sah ohne Farbe ziehmlich... farblos und langweilig aus.
![Vergleich von Text ohne Farbe](https://user-images.githubusercontent.com/111045604/191684991-4b889abc-24ac-4136-b0a1-5761ae81a939.png)
Dann hab ich auf Stackoverflow gesucht, wie man Textfarbe verändert. Ich habe folgenden Code gefunden :
``` csharp
Console.Foregroundcolor = ConsoleColor.Green ;       // Ich ändere die Farbe des Textes
Console.WriteLine("Richtig geraten! " + Geheimzahl + " war richtig!") ;   // Ich bestimme, was die Konsole sagt (jetzt in Farbe)
Console.Foregroundcolor = ConsoleColor.White ;        // Ich ändere die Farbe des Textes zurück
```
Doch jedes mal, wenn man etwas auf der Konsole ausgeben will, muss man diese 3 Zeilen von Text eintippen.
Um das leichter zu machen, kann man einfach eine Funktion dafür erstellen :
``` csharp
void ftext(string text, ConsoleColor fcolor)  // Ich erstelle die Funktion
     {
      ConsoleColor fc = Console.Foregroundcolor;    // Ich erstelle eine Variable, die die jetzige Farbe einspeichert
      Console.Foregroundcolor = fcolor;           // Ich setze die Farbe zu der Variable, die ich mit der Funktion bestimme
      Console.WriteLine(text);                 // Die Konsole gibt jetzt den Text aus, den ich mit der Funktion bestimme
      Console.Foregroundcolor = fc;          // Am Schluss setze ich die Farbe zurück auf die, die es vorher war
     }
```
Damit habe ich jetzt Farbe ausgeben gelernt!
Am schluss sieht der verleichterte Code so aus:
``` csharp
ftext("Richtig geraten!", ConsoleColor.Red);
```
So sieht dann der neue, bunte und verständliche Text aus:
![Vergleich von Text mit Farbe](https://user-images.githubusercontent.com/111045604/191687611-5e0d1cdf-e815-4d6a-af16-e926eefe8ce8.png)

## Verifikation

Der Text beschreibt, was ich gemacht habe und wie ich mich gefühlt habe.
Die Bilder zeigen, wie viel schöner Text mit Farbe ist als Text ohne.
Die Code - Snippets zeigen, was für Code ich eingesetzt habe und wie ich programmiert habe.

# Reflektion zum Arbeitsprozess

Ich war bei meiner Arbeit sehr konzentriert und motiviert, denn jedes Mal wo ich etwas neues konnte,
wurde ich motivierter und glücklicher. Ich wurde immer mehr aufgeregt, mehr zu programmieren.

Manchmal wenn ich ein Fehler nicht korrigieren konnte, gab ich zu schnell auf. Auch wenn ich meinen eigenen Code nicht mehr
verstand, fing ich an, aufzugeben.

**VBV**: Ich muss meinen Code besser organisieren, damit er übersichtlicher ist und ich muss versuchen, auch vielleicht einen Kollegen, der
         schon gut programmieren kann, um Hilfe zu bitten. Auch könnte ich auf Stackoverflow.com eine Frage stellen.
