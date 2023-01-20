namespace Project_Pacman
{
    class Outro
    {
        private Intro intro = new Intro();

        public Intro GetIntro()
        {
            return intro;
        }

        public void OutroScene(Intro intro)
        {
            Console.ForegroundColor = ConsoleColor.White;

            int result = Player.Score;
            Console.WriteLine();
            Console.WriteLine("                                               [Total Score]");
            Console.WriteLine();

            Console.WriteLine("                                ┌----------------------------------------┐");
            Console.WriteLine("                                │                                        │");
            Console.WriteLine("                                │                                        │");
            Console.WriteLine($"                                │                   {result,2}                   │");
            Console.WriteLine("                                │                                        │");
            Console.WriteLine("                                │                                        │");
            Console.WriteLine("                                └----------------------------------------┘");

            Console.WriteLine("                                ┌----------------------------------------┐");
            Console.WriteLine("                                │                                        │");
            Console.WriteLine("                                │                                        │");
            Console.WriteLine("                                │                                        │");
            Console.WriteLine("                                │              1.다시 시작               │");
            Console.WriteLine("                                │              2.게임 종료               │");
            Console.WriteLine("                                │                                        │");
            Console.WriteLine("                                │                                        │");
            Console.WriteLine("                                │                                        │");
            Console.WriteLine("                                └----------------------------------------┘");
            Console.WriteLine("\n\n");
            Console.Write("                                 번호 입력 >> ");

            try
            {
                int key = Convert.ToInt32(Console.ReadLine());
                if (key == 1)
                {
                    Console.WriteLine("새 게임을 시작합니다");
                    GameKill();
                    Console.Clear();
                    Intro.PrintScreen();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("[ 게임을 종료합니다 ]\n");
                    Environment.Exit(2);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Clear();
                OutroScene(GetIntro());
            }

        }

        public void GameKill()
        {
            Player.playerisRun = false;
            Program.gameisRun = false;
        }
    }
}
