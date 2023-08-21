using DemoLibrary;

namespace SQLite_Demo
{
    public partial class PeopleForm : Form
    {
        List<PersonModel> people = new List<PersonModel>();
        public PeopleForm()
        {
            InitializeComponent();
            LoadPeopleList();
        }

        private void LoadPeopleList()
        {
            people.Add(new PersonModel { Nombre = "Cris", Apellido = "Binimelis" });
            people.Add(new PersonModel { Nombre = "Eve", Apellido = "Sepúlveda" });
            people.Add(new PersonModel { Nombre = "Señor", Apellido = "Mostachete" });

            WireUpPeopleList();
        }

        private void WireUpPeopleList()
        {
            lb_listPerson.DataSource = null;
            lb_listPerson.DataSource = people;
            lb_listPerson.DisplayMember = "NombreCompleto";
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadPeopleList();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            PersonModel p = new PersonModel();

            p.Nombre = tbx_nombre.Text;
            p.Apellido = tbx_apellido.Text;

            people.Add(p);
            WireUpPeopleList();

            tbx_nombre.Text = "";
            tbx_apellido.Text = "";

        }
    }
}