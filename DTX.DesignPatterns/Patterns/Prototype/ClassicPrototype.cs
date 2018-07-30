using System;

namespace DTX.DesignPatterns.Patterns.Prototype
{
    public static class ClassicPrototype
    {
        public abstract class Robot
        {
            protected int ArmsCount { get; }
            protected int LegsCount { get; }

            protected Robot(int arms, int legs)
            {
                ArmsCount = arms;
                LegsCount = legs;
            }

            public abstract Robot Clone();
            public abstract void ShowInfo();
        }

        private class FriendlyRobot : Robot
        {
            public int Softness { get; set; }

            public FriendlyRobot(int arms, int legs) : base(arms, legs)
            {
            }

            private FriendlyRobot(FriendlyRobot source) : base(source.ArmsCount, source.LegsCount)
            {
                Softness = source.Softness;
            }

            public override Robot Clone()
            {
                return new FriendlyRobot(this);
            }

            public override void ShowInfo()
            {
                Console.WriteLine($@"Softness:{Softness}    Arms:{ArmsCount}    Legs:{LegsCount}");
            }
        }

        private class HostileRobot : Robot
        {
            public int Aggressiveness { get; set; }

            public HostileRobot(int arms, int legs) : base(arms, legs)
            {
            }

            private HostileRobot(HostileRobot source) : base(source.ArmsCount, source.LegsCount)
            {
                Aggressiveness = source.Aggressiveness;
            }

            public override Robot Clone()
            {
                return new HostileRobot(this);
            }

            public override void ShowInfo()
            {
                Console.WriteLine($@"Aggressiveness:{Aggressiveness}    Arms:{ArmsCount}    Legs:{LegsCount}");
            }
        }


        
        public static void Start()
        {
            Console.WriteLine(@"Friendly Robot's Info:");
            var friendlyRobot = new FriendlyRobot(5, 10) {Softness = 10};
            friendlyRobot.ShowInfo();
            Console.WriteLine();

            Console.WriteLine(@"Friendly Robot copy Info:");
            if (friendlyRobot.Clone() is FriendlyRobot friendlyRobotCopy)
                friendlyRobotCopy.ShowInfo();
            Console.WriteLine();

            Console.WriteLine(@"Hostile Robot's Info:");
            var hostileRobot = new HostileRobot(2, 2) {Aggressiveness = 20};
            hostileRobot.ShowInfo();
            Console.WriteLine();

            Console.WriteLine(@"Hostile Robot copy Info:");
            if (hostileRobot.Clone() is HostileRobot hostileRobotCopy)
                hostileRobotCopy.ShowInfo();
        }
    }
}