namespace DZ
{
    class Converter

    {
        public double DollarToGrivna = 26.32;

        public double EuroToGrivna = 30.46;



        public double CToDollars(double grivnas)
        {
            if (grivnas == 0) return 0.0;
            return grivnas / DollarToGrivna;
        }


        public double CDollars(double dollars)
        {
            if (dollars == 0) return 0.0;
            return dollars * DollarToGrivna;
        }



        public double CToEuros(double grivnas)
        {
            if (grivnas == 0) return 0.0;
            return grivnas / EuroToGrivna;
        }


        public double CEuros(double euros)
        {
            if (euros == 0) return 0.0;
            return euros * EuroToGrivna;
        }

        
        
    }
}