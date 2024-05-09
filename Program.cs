using AutoMapper;


namespace Mapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CactusMapper");

            Cactus emp = new Cactus();

            emp.Id = 888;
            emp.Name = "Cactus1";
            emp.Title = "CactusTitle1";
            emp.Description = "CactusDescription1";



            CactusDto dto = new CactusDto();

            dto.Id = emp.Id;
            dto.Name = emp.Name;
            dto.Title = emp.Title;
            dto.Description = emp.Description;


            Console.WriteLine(dto.Id + " " + dto.Name + " " + dto.Title + " " + dto.Description);
            Console.WriteLine("----------Nüüd algab Automapper----------");


            Cactus employee = new Cactus()
            {
                Id = 098,
                Name = "Cactus123",
                Description = "CactusDesc123",
                Title = "CactusTitle123",
            };

            var mapper = Program.InitializeAutomapper();

            var empDto2 = mapper.Map<Cactus, CactusDto>(employee);

            Console.WriteLine(empDto2.Id + " " + empDto2.Name + " " + empDto2.Title + " " + empDto2.Description);


        }


        public static Mapper InitializeAutomapper()
        {

            var confiq = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<Cactus, Cactus>();
            });


            var mapper = new Mapper(confiq);

            return mapper;
        }
    }




    public class Cactus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }


    public class CactusDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
