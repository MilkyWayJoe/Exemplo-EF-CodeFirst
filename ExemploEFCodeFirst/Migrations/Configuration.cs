namespace ExemploEFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ExemploEFCodeFirstDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ExemploEFCodeFirstDBContext context)
        {
            #region Usuarios
            var bauer = new Usuario() {
                Id = 1,
                PrimeiroNome = "Jack",
                UltimoNome = "Bauer",
                Status = "Desaparecido",
                Email = "bauer@ctu.gov",
            };
            var wayne = new Usuario() {
                Id = 2,
                PrimeiroNome = "Bruce",
                UltimoNome = "Wayne",
                Status = "Desaparecido",
                Email = "the@batman.com",
            };
            var bond = new Usuario() {
                Id = 3,
                PrimeiroNome = "James",
                UltimoNome = "Bond",
                Status = "Ativo",
                Email = "007@mi6.gov.uk",
            };
            #endregion 

            #region Usuarios
            var post1 = new Post()
            {
                Id = 1,
                Titulo = "Titulo post 1",
                Conteudo = "Bacon ipsum dolor sit amet ribeye beef strip steak tongue shankle spare ribs, turkey cow short ribs t-bone. Tri-tip ball tip ground round prosciutto t-bone, pork belly cow turkey capicola bresaola boudin shankle flank pork chop. Meatloaf tongue turducken filet mignon drumstick tenderloin. Ham hock turducken t-bone fatback strip steak chuck, filet mignon meatball swine pork loin tail pork beef pork belly tri-tip. Andouille pork chop capicola sirloin brisket spare ribs short ribs tri-tip hamburger meatball meatloaf.",
                Autor = bauer
            };

            var post2 = new Post()
            {
                Id = 2,
                Titulo = "Titulo post 2",
                Conteudo = "Spare ribs short ribs cow turkey frankfurter. Pork shank shankle rump, capicola short loin ball tip shoulder turducken venison tail kielbasa tongue turkey bresaola. Ground round ball tip prosciutto pancetta chicken rump shank biltong tail ham capicola drumstick pastrami turducken. Strip steak prosciutto frankfurter beef sirloin turkey shank boudin bacon. Corned beef tongue biltong pig ground round frankfurter, hamburger bacon fatback ball tip. Bacon sirloin chuck prosciutto shoulder fatback turkey salami pork chop jowl beef.",
                Autor = bond
            };

            var post3 = new Post()
            {
                Id = 3,
                Titulo = "Titulo post 3",
                Conteudo = "Sausage kielbasa meatball swine t-bone, pork turkey leberkas ground round salami shoulder prosciutto bresaola short loin. Pork chop short ribs sirloin filet mignon, leberkas boudin t-bone ham andouille tail shoulder capicola ribeye. T-bone andouille spare ribs prosciutto frankfurter ball tip chuck jowl rump chicken shankle meatball tenderloin pig. Drumstick meatball pancetta chuck.",
                Autor = wayne
            };
            #endregion
            

            context.Usuarios.AddOrUpdate(
                bauer, wayne, bond
            );

            context.Posts.AddOrUpdate(
                post1, post2, post3
            );
        }
    }
}
