//Skriv en konsolapplikation för att skapa följande klasser:
//•	DrawObject som innehåller en virtuell metod Draw() som skriver ut texten ”Jag är bas ritobjekt.",
//•	Klass Line som ärver klassen DrawObject och har metoden Draw()
//•	Circle som ärver DrawObject-klassen och har en Draw()-metod,
//•	Kvadrat som ärver klassen DrawObject och har metoden Draw()
//•	DemoForDrawing (där Main /program.cs) - funktionen definieras med skapade objekt för ritning

using Ex3;

DrawObject[] drawObjects = new DrawObject[4];
drawObjects[0] = new Line();
drawObjects[1] = new Circle();
drawObjects[2] = new Square();
drawObjects[3] = new DrawObject();

foreach (DrawObject drawObject in drawObjects)
{
    drawObject.Draw();
}

Console.ReadKey();