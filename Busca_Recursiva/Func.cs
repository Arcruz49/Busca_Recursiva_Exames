
namespace Busca_Recursiva
{
    public class Func
    {
        public List<Exame> GetExames()
        {
            return new List<Exame>
            {
                new Exame { Name = "HDL" },
                new Exame { Name = "LDL" },
                new Exame { Name = "VLDL" },
                new Exame { Name = "TRIGLICERIDES" },
                new Exame { Name = "LIPIDES TOTAIS" },
                new Exame { Name = "COLESTEROL TOTAL" },
                new Exame { Name = "COLESTEROL TOTAL, F, T" },
                new Exame 
                { 
                    Name = "LIPIDOGRAMA", 
                    Servicos = new List<Exame>
                    {
                        new Exame { Name = "COLESTEROL TOTAL" },
                        new Exame { Name = "HDL" },
                        new Exame { Name = "LDL" },
                        new Exame { Name = "VLDL" },
                        new Exame { Name = "TRIGLICERIDES" },
                        new Exame { Name = "LIPIDES TOTAIS" },
                    }
                },
                new Exame 
                { 
                    Name = "COLESTEROL TOTAL, F, T", 
                    Servicos = new List<Exame>
                    {
                        new Exame { Name = "HDL" },
                        new Exame { Name = "LDL" },
                        new Exame { Name = "VLDL" },
                        new Exame { Name = "COLESTEROL TOTAL" },
                        new Exame { Name = "TRIGLICERIDES" },
                    }
                }

            };
        }


        public Exame GetLipidograma()
        {
            return new Exame 
            { 
                Name = "LIPIDOGRAMA", 
                Servicos = new List<Exame>
                {
                    new Exame { Name = "HDL" },
                    new Exame { Name = "LDL" },
                    new Exame { Name = "VLDL" },
                    new Exame { Name = "TRIGLICERIDES" },
                    new Exame { Name = "LIPIDES TOTAIS" },
                    new Exame 
                    { 
                        Name = "COLESTEROL TOTAL, F, T", 
                        Servicos = new List<Exame>
                        {
                            new Exame { Name = "HDL" },
                            new Exame { Name = "LDL" },
                            new Exame { Name = "VLDL" },
                            new Exame { Name = "COLESTEROL TOTAL" },
                            new Exame { Name = "TRIGLICERIDES" },
                        }
                        
                    }
                }
            };
        }

        public Exame GetColesterolTotalFT()
        {
            return new Exame 
            { 
                Name = "COLESTEROL TOTAL, F, T", 
                Servicos = new List<Exame>
                {
                    new Exame { Name = "HDL" },
                    new Exame { Name = "LDL" },
                    new Exame { Name = "VLDL" },
                    new Exame { Name = "COLESTEROL TOTAL" },
                    new Exame { Name = "TRIGLICERIDES" },
                }
            };
        }

        public Exame GetColesteroltotal()
        {
            return new Exame { Name = "COLESTEROL TOTAL" };
        }

    }
}
