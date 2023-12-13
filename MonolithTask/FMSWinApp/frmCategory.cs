using Business.Abstract;
using Entities.TableModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMSWinApp
{
    public partial class frmCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public frmCategory(ICategoryService categoryService) : this()
        {
            _categoryService = categoryService;
        }
        public frmCategory()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = _categoryService.GetAll().Data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var category = new Category
            {
                Name = textBox1.Text,
            };

            var result = _categoryService.Add(category);
            if (result.IsSuccess)
            {
                LoadData();
            }

            MessageBox.Show(result.Message);
        }
    }
}
