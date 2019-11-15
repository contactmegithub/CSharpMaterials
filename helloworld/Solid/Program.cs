using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class BaseBurgerMaker
    {
        private BunMaker bunMaker;
        private VegMaker vegMaker;
        private Toppings toppings;

        public BaseBurgerMaker(BunMaker _BunMaker, VegMaker _VegMaker, Toppings _Toppings)
        {
            bunMaker = _BunMaker;
            vegMaker = _VegMaker;
            toppings = _Toppings;
        }
        public void Deliver()
        {
            bunMaker.Deliver();
            vegMaker.Deliver();
            toppings.Deliver();
        }
    }
    public class BurgerA: BaseBurgerMaker
    {
        public BurgerA(BunMaker _BunMaker, VegMaker _VegMaker, Toppings _Toppings) : base(_BunMaker, _VegMaker, _Toppings)
        {
        }

        private void Step1()
        {

        }
        private void Step2()
        {

        }
        private void Step3()
        {

        }

        public void Deliver()
        {
            base.Deliver();
            Step1();
            Step2();
            Step3();
        }
    }
    public class BurgerB: BaseBurgerMaker
    {
        public BurgerB(BunMaker _BunMaker, VegMaker _VegMaker, Toppings _Toppings) : base(_BunMaker, _VegMaker, _Toppings)
        {
        }
        private void Step1()
        {

        }
        private void Step2()
        {

        }
        private void Step3()
        {

        }

        public void Deliver()
        {
            base.Deliver();
            Step1();
            Step2();
            Step3();
        }
    }
    public class BurgerC
    {
        private BunMaker bunMaker;
        private VegMaker vegMaker;
        private Toppings toppings;

        public BurgerC(BunMaker _BunMaker, VegMaker _VegMaker, Toppings _Toppings)
        {
            bunMaker = _BunMaker;
            vegMaker = _VegMaker;
            toppings = _Toppings;
        }
        private void Step1()
        {

        }
        private void Step2()
        {

        }
        private void Step3()
        {

        }
        public void Deliver()
        {
            bunMaker.Deliver();
            vegMaker.Deliver();
            toppings.Deliver();
            Step1();
            Step2();
            Step3();
        }
    }

    public class BunMaker
    {
        public void Deliver()
        {

        }
    }
    public class MeatMaker
    {
        public void Deliver()
        {

        }
    }
    public class VegMaker
    {
        public void Deliver()
        {

        }
    }
    public class Toppings
    {
        public void Deliver()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BunMaker bunMaker = new BunMaker();
            MeatMaker _MeatMaker = new MeatMaker();
            VegMaker _VegMaker = new VegMaker();
            Toppings _Toppings = new Toppings();
            BurgerA _BurgerA = new BurgerA(bunMaker, _VegMaker, _Toppings);
            _BurgerA.Deliver();

        }
    }
}
