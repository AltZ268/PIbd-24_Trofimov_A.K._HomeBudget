using HomeBudget.Entities;
using HomeBudget.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeBudget.Forms
{
    public partial class FormIncomeSource : Form
    {
        private readonly IIncomeSourceRepository _incomeSourceRepository;

        private int? _incomeSourceId;

        public int Id
        {
            set
            {
                try
                {
                    var incomeSource = _incomeSourceRepository.ReadIncomeSourceById(value);
                    if (incomeSource == null)
                    {
                        throw new InvalidDataException(nameof(incomeSource));
                    }
                    textBoxType.Text = incomeSource.Type;
                    _incomeSourceId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        public FormIncomeSource(IIncomeSourceRepository incomeSourceRepository)
        {
            InitializeComponent();
            _incomeSourceRepository = incomeSourceRepository ?? throw new ArgumentNullException(nameof(incomeSourceRepository));
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxType.Text))
                {
                    throw new Exception("Имеются незаполненные поля");
                }
                if (_incomeSourceId.HasValue)
                {
                    _incomeSourceRepository.UpdateIncomeSource(CreateIncomeSource(_incomeSourceId.Value));
                }
                else
                {
                    _incomeSourceRepository.CreateIncomeSource(CreateIncomeSource(0));
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();

        private IncomeSource CreateIncomeSource(int id) => IncomeSource.CreateEntity(id, textBoxType.Text)
    }
}
