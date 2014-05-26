using PagedTableAspNetMvc.Models;

namespace PagedTableAspNetMvc.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PagedTableAspNetMvc.Models.ExampleDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PagedTableAspNetMvc.Models.ExampleDataContext context)
        {
            var records = PeopleData
                .Split('\n')
                .Select(x =>
                {
                    var p = x.Split(',');
                    return new Person { FullName = p[0], Phone = p[1], Email = p[2] };
                });

            context.People.AddOrUpdate(x => x.FullName, records.ToArray());

        }

        public string PeopleData
        {
            get
            {
                return
                    @"Edan S. Osborne,(224) 317-6354,Cras.convallis.convallis@dolorquamelementum.org
Connor N. Hewitt,(792) 576-9742,Nulla@Aliquam.edu
Tana B. Clemons,(634) 792-9803,volutpat.Nulla@in.edu
Odysseus M. Osborn,(568) 388-3649,augue.eu@pellentesque.com
Fallon W. Vinson,(134) 413-9559,non@musProinvel.co.uk
Jeremy X. Foley,(743) 118-1575,In.lorem.Donec@nuncQuisque.org
Lacota B. Zamora,(485) 800-2221,Fusce@nasceturridiculus.net
Wynne D. Valencia,(524) 985-5112,risus.Donec@sociis.ca
Raven U. Powell,(446) 504-6142,Nam.ac.nulla@vulputateeuodio.co.uk
Blaze A. Church,(914) 315-0201,Phasellus.at@mattisornarelectus.net
Vivian P. Richards,(757) 783-9883,egestas.Aliquam.fringilla@eget.edu
Jack I. Mclaughlin,(280) 261-4567,Duis.risus@vitaeposuereat.co.uk
Vivien S. Waller,(334) 753-4478,convallis.in.cursus@antedictum.edu
Ifeoma P. Benton,(457) 425-1969,risus.Morbi.metus@eget.co.uk
Noah I. Black,(776) 667-4174,ad.litora@utquam.net
Stuart C. Howard,(139) 196-8908,libero.Proin@velitPellentesqueultricies.edu
Rana Q. Malone,(357) 743-7440,enim@vestibulumloremsit.co.uk
Casey J. Moore,(730) 665-3286,sociis@MaurismagnaDuis.net
Orlando G. Foley,(588) 869-1274,tincidunt.orci.quis@litoratorquentper.edu
Prescott R. Obrien,(617) 353-3703,Nulla.tempor@leo.com
Blake N. Barrett,(963) 887-6255,laoreet.libero@egetmetusIn.com
Victor C. Myers,(940) 998-1771,Proin@acipsumPhasellus.edu
Asher F. Montgomery,(433) 457-7515,mattis@portaelit.ca
Callum D. Ward,(670) 573-4288,mollis.Integer@feugiatnec.org
Dora H. Graves,(114) 346-6820,turpis@Nunc.org
Tatum B. Trujillo,(510) 792-4377,purus.sapien@pretiumetrutrum.edu
Candice Q. Henson,(166) 744-9428,diam.Sed.diam@Donecelementumlorem.net
Geoffrey S. Day,(507) 566-4712,ullamcorper.Duis.cursus@diamDuismi.edu
Christopher C. Carver,(125) 308-9951,Aliquam@ut.co.uk
Colby F. Tanner,(165) 136-8987,Aliquam.nisl@lacusUt.edu
Yvette P. Francis,(342) 211-3060,sed@nonummyutmolestie.edu
Zeph Y. Donovan,(514) 551-6915,molestie.Sed.id@Suspendisse.net
Hector Z. Hood,(675) 229-5626,Proin.mi.Aliquam@a.com
Oscar E. Hatfield,(743) 335-5034,eleifend.egestas@euismod.ca
Ignacia V. Williams,(794) 202-0647,magna.a@malesuadafames.edu
Mara V. Brown,(278) 881-4672,tristique.neque.venenatis@magnamalesuada.ca
Ray O. Lindsey,(467) 645-1908,volutpat.ornare.facilisis@felis.net
Miriam F. Frazier,(897) 762-7551,sociis.natoque.penatibus@gravidaPraesent.co.uk
Eugenia D. Harding,(267) 483-9054,pede.Cum@sagittisDuis.com
Glenna W. Sanders,(102) 214-9033,non@consectetuercursuset.co.uk
Lara A. Davis,(781) 510-6026,Nam@non.ca
Nigel X. Pope,(969) 899-5932,eget.volutpat@vulputateposuere.org
Keelie T. Mcmillan,(733) 585-2981,feugiat.tellus.lorem@nonmagnaNam.com
Jeremy O. Hartman,(125) 957-4061,euismod@urnaVivamusmolestie.org
Paula M. Parsons,(395) 539-0689,elementum.purus@Phasellus.ca
Noelle H. Kirkland,(863) 997-4216,neque@laciniamattis.org
Ross X. Zamora,(551) 512-0187,Etiam.imperdiet@fringillapurusmauris.org
Colorado A. Perry,(316) 483-3259,molestie.arcu.Sed@facilisisnon.ca
Dillon Z. Harvey,(644) 869-4213,non.leo@at.ca
Nichole S. Cabrera,(787) 368-5030,amet.consectetuer.adipiscing@elementum.net
Caleb E. Clemons,(436) 166-2563,Quisque@odioauctor.co.uk
Ann D. Nolan,(117) 541-5513,mus.Proin@interdumlibero.edu
Wylie W. Hill,(802) 610-2162,rutrum.eu.ultrices@nibhPhasellusnulla.edu
Fay Q. Jefferson,(349) 137-7030,lobortis.tellus@magnaPraesentinterdum.net
Julian L. Church,(697) 391-5844,at@metusvitae.org
Kylan Y. Koch,(452) 809-1061,nulla@pede.com
Callie D. Rivera,(369) 426-5366,Aliquam.vulputate@magna.ca
Iris D. Mckenzie,(595) 963-2200,lacus.pede.sagittis@Phasellus.net
Tashya S. Leach,(983) 106-0233,scelerisque.mollis.Phasellus@metuseu.net
Kessie I. Kirby,(159) 989-4045,erat.eget@miloremvehicula.org
Kibo Q. Scott,(968) 302-5672,amet.lorem.semper@mauriseuelit.co.uk
Lamar N. Johnson,(161) 130-4820,lobortis.augue.scelerisque@velitinaliquet.edu
Miranda N. Davis,(137) 887-2923,velit@ultrices.edu
Berk R. Lindsey,(859) 239-6461,Nulla.eu@laoreetposuereenim.com
Jasmine E. Lopez,(835) 493-8112,orci.Ut@vitaealiquet.net
Ora T. Gould,(400) 711-6811,non@tristiqueaceleifend.net
Brent P. Kirk,(383) 831-4005,Nullam.velit@dignissimlacus.org
Quinn Y. Barnes,(603) 881-5492,vulputate@Donec.org
Gloria J. Richmond,(235) 374-3735,nisi.dictum@egetvarius.ca
Bevis R. Parker,(288) 932-2013,Curae@risusa.edu
Kieran Q. Lawson,(991) 712-1489,mauris@sit.co.uk
Idona S. Jarvis,(496) 689-0747,scelerisque@maurisInteger.edu
Ruth N. Velasquez,(259) 387-6535,Cras.lorem.lorem@nonummyultricies.ca
Damon Z. Fitzpatrick,(406) 870-0976,Suspendisse@sedturpisnec.com
Minerva K. Phelps,(637) 940-2818,Morbi@nequevenenatis.com
Kylynn K. Carney,(678) 289-3007,mauris@molestiesodalesMauris.co.uk
Arden Z. Gilbert,(543) 692-5846,Integer.urna@purusin.net
Herman Z. Gallagher,(304) 363-6176,dignissim.lacus.Aliquam@Suspendissealiquetmolestie.co.uk
Cheryl I. Waller,(150) 374-3210,tellus.Phasellus.elit@Sed.org
Sylvia B. Lamb,(321) 687-4677,velit.Aliquam@fermentumrisusat.ca
Xavier V. Chavez,(599) 987-8965,dui.Suspendisse@estac.net
George E. Wood,(554) 131-6617,nostra.per@sit.net
Joseph D. Cooper,(437) 717-5774,orci@loremvitae.net
Ella P. Schwartz,(144) 294-5938,massa@dolorsit.com
Sydney R. Swanson,(872) 329-0257,eget.nisi@Phasellus.edu
Arden K. Figueroa,(513) 688-6345,ornare.lectus.justo@ridiculus.net
Aurora S. Patrick,(188) 210-7397,velit@enim.edu
Lareina Z. Mercer,(314) 446-6831,eget.metus@neque.co.uk
Sopoline M. Alvarez,(593) 774-3809,lacus.Ut.nec@egetmagnaSuspendisse.co.uk
Nomlanga F. Davidson,(863) 764-6174,eu.dui.Cum@vehiculaetrutrum.org
Rashad X. Morse,(289) 746-1926,nec@nulla.com
Raya M. Pugh,(699) 181-4581,taciti@malesuadaut.org
Dean T. Daugherty,(221) 543-6543,euismod.urna.Nullam@vitae.co.uk
Quyn F. Mosley,(573) 135-9662,purus.mauris.a@erat.co.uk
Guinevere E. Miles,(334) 868-3399,vel@nullavulputatedui.com
Sade B. Boyd,(806) 532-9066,egestas.blandit@lorem.co.uk
Marny K. Hansen,(846) 523-5427,Sed@magnaUttincidunt.com
Farrah G. Talley,(697) 457-4831,Quisque.tincidunt@nonlaciniaat.edu
Vielka P. Tate,(961) 471-1737,Phasellus.vitae.mauris@orci.org
Brianna S. Gates,(895) 264-8742,nec@quamelementum.edu";
            }
        }

    }
}
