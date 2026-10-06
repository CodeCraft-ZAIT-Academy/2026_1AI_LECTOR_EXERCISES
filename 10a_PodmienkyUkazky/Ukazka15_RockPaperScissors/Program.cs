// ===== 15 – Kameň, nožnice, papier =====
// Ukáž:       zložené podmienky nad textami. Najprv remíza, potom výhry hráča 1, inak vyhráva hráč 2.
// Skús zmeniť: player1 a player2 na "rock", "scissors", "paper" – všetkých 9 kombinácií.

string player1 = "rock";
string player2 = "scissors";

if (player1 == player2)
{
    Console.WriteLine("Draw!");
}
else if ((player1 == "rock" && player2 == "scissors") ||
         (player1 == "scissors" && player2 == "paper") ||
         (player1 == "paper" && player2 == "rock"))
{
    Console.WriteLine("Player 1 wins!");
}
else
{
    Console.WriteLine("Player 2 wins!");
}
