using System;

class Program
{
    static void Main(string[] args)
    {
        /* Star Simulations */
        Star sirius = new Star("Sirius", "Main Sequence");
        sirius.Shine();
        sirius.GrowOlder();
        sirius.Shine();

        Star unknownStar = new Star("X-101");
        unknownStar.Shine();
        unknownStar.GrowOlder();
        unknownStar.Shine();
        unknownStar.Supernova();
        unknownStar.Shine();
    }
}
