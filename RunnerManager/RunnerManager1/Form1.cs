using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Globalization;

namespace RunnerManager1
{
    public partial class Form1 : Form
    {
        // Strings para recoger los datos introducidos en el formulario. Los campos Si/No se inicializan a NO;
        private String idNumber;
        private String insertDate;
        private String name;
        private String familyName1;
        private String familyName2;
        private String email;
        private String telefone;
        private String zip;
        private String birthDate;
        private String record;
        private String certificatedRecord = NO;
        private String gender;
        private String shirtSize;
        private String shirtName;
        private String nonForProfit = NO;
        private String news = NO;
        private String calification;

        // Strings para los campos dicotómicos Si/No
        private const String YES = "si";
        private const String NO = "no";

        // List que contiene los valores a introducir en la base de datos
        private List<String> dbValues = new List<String>();

        // String que recoge los campos de la base de datos
        private const String fields = "DNI_NIE,Fecha_Inscripcion,Nombre,Apellido1,Apellido2,Email,Telefono,CP,Fecha_Nacimiento,Marca_Habitual," + 
            "Marca_Acreditada,Genero,Talla,Nombre_Camiseta,Inscripcion_Solidaria,Noticias";

        // Instancia de conexión a la base de datos
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\apene\Documents\Runners.mdb");

        public Form1()
        {
            InitializeComponent();
        }
        /*
         campos base de datos
         ,Fecha_Inscripcion,Nombre,Apellido1,Apellido2,Email,Telefono,CP,Fecha_Nacimiento,Marca_Habitual,Marca_Acreditada," +
                    "Genero,Talla,Nombre_Camiseta,Inscripcion_Solidaria,Noticias*/

        // Al establecer el género, si marcamos mujer se desmarcará hombre en caso de que estubiera marcado y viceversa
        private void RbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked)
            {
                rbMale.Checked = false;
                rbFemale.Checked = true;
            }

        }
        private void RbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked)
            {
                rbFemale.Checked = false;
                rbMale.Checked = true;
            }

        }

        // Manejador del botón Guardar Datos
        private void BtnSaveRunner_Click(object sender, EventArgs e)
        {
            // Utilizamos un StringBuilder con el que construiremos la cadena de valores a introducir en la base de datos
            StringBuilder str = new StringBuilder();
            
            // Ejecutamos método GetStrings
            GetStrings();

            // Si el número de elementos en el list coincide con el número de elementos a insertar en la base de datos, intentamos la inserción
            if (dbValues.Count == 16)
            {
                // Recorremos el List con los valores y los añaidmos al str
                for (int i = 0; i < dbValues.Count; i++)
                {
                    if (str.Length > 0)
                    {
                        str.Append(",'" + dbValues[i] + "'");
                    } else if (i==9) // manejamos el caso del campo Marca_Habitual, que es un número y no lleva ''
                    {
                        str.Append("," + dbValues[i]);
                    } else
                    {
                        str.Append("'" + dbValues[i] + "'");
                    }
                
                }

                try
                {
                    // Abrimos la conexión con la base de datos, insertamos los datos introducidos por el usuario y cerramos la conexión
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Runners(" + fields + ") values (" + str.ToString() + ")";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    // Confirmamos por pantalla que el registro ha sido correcto y los valores introducidos
                    MessageBox.Show("Añadido correctamente con los valores: " + str.ToString(), "Confirmación de Registro");

                }
                catch (OleDbException odbex)
                {
                    // Manejamos la excepción y cerramos la conexión
                    con.Close();
                    MessageBox.Show("Error al escribir en la base de datos. Error: " + odbex.ToString());
                }
                catch (Exception ex)
                {
                    // Manejamos la excepción y cerramos la conexión
                    con.Close();
                    MessageBox.Show("Error: " + ex.ToString());
                }

            } else
            {
                // el número de campos no ha coincidido, seguimos el código limpiando el List y el String Builder
            }

           
            // Vaciamos el list de valores de la base de datos y el StringBuilder
            dbValues.Clear();
            str = null;

        }

        // Manejador del botón Buscar
        private void BtSearch_Click(object sender, EventArgs e)
        {
            String idSearch = "*";
            String nameSearch = "*";
            String familySearch = "*";
            
            // Si no ha rellenado campos de búsqueda mostramos error solicitando que rellene alguno
            if (string.IsNullOrWhiteSpace(tbIdSearch.Text) && string.IsNullOrWhiteSpace(tbNameSearch.Text) && string.IsNullOrWhiteSpace(tbFamilyNameSearch.Text))
            {
                MessageBox.Show("Debe introducir algún elemento de búsqueda, los campos deben ser coincidentes", "Error");
            } else // en otros casos, pasamos los parámetros de búsqueda a los string para la consulta
            {
                if (!string.IsNullOrEmpty(tbIdSearch.Text))
                {
                    idSearch = tbIdSearch.Text;
                }
                if (!string.IsNullOrWhiteSpace(tbNameSearch.Text))
                {
                    nameSearch = tbNameSearch.Text;
                }
                if (!string.IsNullOrWhiteSpace(tbFamilyNameSearch.Text))
                {
                    familySearch = tbFamilyNameSearch.Text;
                }

                String query = "select * from Runners where DNI_NIE like '%" + idSearch + "%' or Nombre like '%" + nameSearch + "%' or Apellido1 like '%" + familySearch + "%'";
                
                try // conectamos con la BBDD, realizamos la consulta y rellenamos el datagridview con los datos obtenidos
                {
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();                    
                    OleDbDataAdapter dba = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dba.Fill(dt);
                    dgvSearchEditResult.DataSource = dt;
                    // Cerramos la base de datos
                    con.Close();

                }
                catch (OleDbException odbex)
                {
                    // Manejamos la excepción y cerramos la conexión
                    con.Close();
                    MessageBox.Show("Error al leer la base de datos. Error: " + odbex.ToString());
                }
                catch (Exception ex)
                {
                    // Manejamos la excepción y cerramos la conexión
                    con.Close();
                    MessageBox.Show("Error: " + ex.ToString());
                }

            }

            // inicializamos los string de consulta a "*";
            idSearch = "*";
            nameSearch = "*";
            familySearch = "*";
            // inicializamos el DataGridView
            dgvSearchEditResult.Refresh();
        }

        // Manejador de eventos del botón Guardar Cambios
        private void BtSaveEdited_Click(object sender, EventArgs e)
        {
            //dgvSearchEditResult.RefreshEdit();
        }

        // Manejador de Eventos del botón Eliminar
        private void BtDelete_Click(object sender, EventArgs e)
        {
            //dgvSearchEditResult.Rows.RemoveAt(dgvSearchEditResult.SelectedRows.);
        }

        // Al seleccionar un item para hacer consultas de Runners mostraremos un ListBox u otro para el detalle de la consulta
        private void LbListRunners_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si selecciona Consulta por género, mostramos el listbox para seleccionar Hombre o Mujer
            if (lbListRunners.SelectedIndex == 1)
            {
                lbGenderSelection.Visible = true;
            } else
            {
                lbGenderSelection.Visible = false;
            }
            
            // Si selecciona Consulta por rangos de edad mostramos el listbox con los rangos de edad
            if (lbListRunners.SelectedIndex == 2)
            {
                lbAgeRangeSelection.Visible = true;
            } else
            {
                lbAgeRangeSelection.Visible = false;
            }

            // Si selecciona Consulta por talla de camiseta mostramos el listbox con las tallas
            if (lbListRunners.SelectedIndex == 3)
            {
                lbTshirtSizeSelecction.Visible = true;
            }
            else
            {
                lbTshirtSizeSelecction.Visible = false;
            }

        }

        // Manejador Botón Listar Runners
        private void BtListRunners_Click(object sender, EventArgs e)
        {
            // Utilizamos un String que almacenará las query
            String query = "";
            // Utilizamos un switch y actuamos según el índice del item seleccionado para las query
            switch (lbListRunners.SelectedIndex)
            {
                case 0: // Listar todos los Runners
                    query = "select * from Runners";
                    break;
                case 1: // Listar Runners por género, 
                    if (lbGenderSelection.SelectedIndex > -1)
                    {
                        if (lbGenderSelection.SelectedIndex == 0) // Si selecciona hombre mostramos los hombres si no, mostramos las mujeres
                        {
                            query = "select * from Runners where Genero='hombre'";
                        } else
                        {
                            query = "select* from Runners where Genero='mujer'";
                        }
                    } else // si no ha seleccionado nada le indicamos que debe seleccionar uno de los dos
                    {
                        MessageBox.Show("Debe seleccionar el género para poder listar", "Error de Consulta");
                    }                    
                    break;
                case 2: // si selecciona consulta por rangos de edad utilizamos String con las fechas para los intervalos
                    String today = DateTime.Now.ToString("dd/MM/yyyy");
                    String queryDate1 = DateTime.Now.AddYears(-25).ToString("dd/MM/yyyy");
                    String queryDate2 = DateTime.Now.AddYears(-35).ToString("dd/MM/yyyy");
                    String queryDate3 = DateTime.Now.AddYears(-45).ToString("dd/MM/yyyy");
                    if (lbAgeRangeSelection.SelectedIndex > -1) // verificamos que ha seleccionado algo
                    {
                        switch (lbAgeRangeSelection.SelectedIndex)
                        {
                            case 0: // para menores de 25 la consulta será entre hoy y hace 25 años
                                query = "select * from Runners where Fecha_Nacimiento between #" + today + "# and #" + queryDate1 + "#";
                                break;
                            case 1: // para el intevalo 25-35 la consulta será entre hace 25 años y hace 35 años
                                query = "select * from Runners where Fecha_Nacimiento between #" + queryDate1 + "# and #" + queryDate2 + "#";
                                break;
                            case 2: // para el intervalo 35-45 la consulta será entre hace 35 años y hace 45 años
                                query = "select * from Runners where Fecha_Nacimiento between #" + queryDate2 + "# and #" + queryDate3 + "#";
                                break;
                            case 3: // para mayores de 45
                                query = "select * from Runners where Fecha_Nacimiento < #" + queryDate3 + "#";
                                break;
                        }
                    }
                    else // si no ha seleccionado nada le indicamos que debe hacerlo
                    {
                        MessageBox.Show("Debe seleccionar el rango de edad para poder listar", "Error de Consulta");
                    }
                    break;
                case 3: // Ver participantes por talla de camiseta
                    if (lbTshirtSizeSelecction.SelectedIndex > -1) // verificamos que ha seleccionado algo
                    {
                        // Como la talla viene en el item seleccionado no necesitamos casos y sirve la misma consulta
                        query = "select * from Runners where Talla = '" + lbTshirtSizeSelecction.SelectedItem.ToString() + "'";
                    }
                    else // si no ha seleccionado nada le indicamos que debe hacerlo
                    {
                        MessageBox.Show("Debe seleccionar el rango de edad para poder listar", "Error de Consulta");
                    }
                    break;
                case 4: // participantes por tiempo estimado de finalización de menor a mayor
                    query = "select * from Runners order by Marca_Habitual asc";
                    break;
                default:
                    MessageBox.Show("Debe seleccionar una lista", "Error de consulta");
                    break;
            }


            try // conectamos con la BBDD, realizamos la consulta y rellenamos el datagridview con los datos obtenidos
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dba = new OleDbDataAdapter(cmd);
                dba.Fill(dt);
                dgvListRunners.DataSource = dt;
                // Cerramos la base de datos
                con.Close();

            }
            catch (OleDbException odbex)
            {
                // Manejamos la excepción y cerramos la conexión
                con.Close();
                MessageBox.Show("Error al leer la base de datos. Error: " + odbex.ToString());
            }
            catch (Exception ex)
            {
                // Manejamos la excepción y cerramos la conexión
                con.Close();
                MessageBox.Show("Error: " + ex.ToString());
            }

            // inicializamos el string de la consulta a "";
            query = "";
        }

        /**
         Este método pasa los datos introducidos a strings que, si son correctos conforme a los requisitos, se añaden al List dbValues.
            Desde el manejador del click se convierte el list en String y se utiliza en el command para insertar los datos. La mayoría de validaciones
            se hacen con métodos específicos ubicados al final de la clase.*/
        private void GetStrings()
        {
            
            // comprobamos el DNI o NIE introducido con el método específico isValidId()
            if (IsValidId(tbIdNumber.Text))
            {
                idNumber = tbIdNumber.Text;
                dbValues.Add(idNumber);
            } else
            {
                MessageBox.Show("Debe introducir un DNI o NIE válido, asegúrese de utilizar mayúsculas para las letras", "Error en los datos introducidos");
            }
            // Recogemos el valor fecha como String, este no será nunca null porque ya tiene por defecto la fecha actual
            insertDate = dtpInsertDate.Text;
            dbValues.Add(insertDate);

            // Recogemos los valores Nombre, Apellido1 y Apellido2. Controlamos que no sea null o espacios en blanco
            if (!string.IsNullOrWhiteSpace(tbName.Text))
            {
                name = tbName.Text;
                dbValues.Add(name);
            } else
            {
                AlertEntryError(lblName.Text);
            }

            if (!string.IsNullOrWhiteSpace(tbFamilyName1.Text))
            {
                familyName1 = tbFamilyName1.Text;
                dbValues.Add(familyName1);
            }
            else
            {
                AlertEntryError(lblFamilyName1.Text);
            }

            if (!string.IsNullOrWhiteSpace(tbFamilyName2.Text))
            {
                familyName2 = tbFamilyName2.Text;
                dbValues.Add(familyName2);
            }
            else
            {
                AlertEntryError(lblFamilyName2.Text);
            }

            // Comprobamos que el correo introducido es válido y lo asignamos al String email
            if (IsValidEmail(tbEmail.Text))
            {
                email = tbEmail.Text;
                dbValues.Add(email);
            } else
            {
                AlertEntryError(lblEmail.Text);
            }

            // Comprobamos el Teléfono y, si es valido lo pasamos al String phone
            if (IsValidPhone(tbTelefone.Text))
            {
                telefone = tbTelefone.Text;
                dbValues.Add(telefone);
            } else
            {
                AlertEntryError(lblTelefone.Text);
            }

            // Comprobamos que el Código Postal es válido y lo recogemos en el String zip
            if (IsValidZip(tbZipCode.Text))
            {
                zip = tbZipCode.Text;
                dbValues.Add(zip);
            } else
            {
                AlertEntryError(lblZipCode.Text);
            }

            // Recogemos el valor fecha nacimiento como String, validamos que sea mayor de edad
            if (IsAdult(CalculateAge(DateTime.Parse(dtpBirthDate.Text))))
            {
                birthDate = dtpBirthDate.Text;
                dbValues.Add(birthDate);
            } else
            {
                MessageBox.Show("¡¡No se pueden inscribir los menores de edad!!", "Error en los datos introducidos");
            }

            // Recogemos el valor de la marca habitual. Si es menor de 30 la marca debe estar acreditada
            if (numUpDownRecord.Value < 30)
            {
                if (cbCertificatedRecord.Checked)
                {
                    record = numUpDownRecord.Value.ToString();
                    certificatedRecord = YES;
                    dbValues.Add(record);
                    dbValues.Add(certificatedRecord);
                } else
                {
                    MessageBox.Show("Recuerde que si la marca habitual es menor de 30 debe aportar certificación", "Error en los datos introducidos");
                }
            } else
            {
                record = numUpDownRecord.Value.ToString();
                dbValues.Add(record);
                dbValues.Add(certificatedRecord);
            }

            // Recogemos el valor de género
            if (!rbFemale.Checked && !rbMale.Checked)
            {
                MessageBox.Show("Debe seleccionar Mujer o Hombre", "Error en los datos introducidos");
            } else
            {
                if (rbFemale.Checked)
                {
                    gender = "mujer";
                    dbValues.Add(gender);
                } else
                {
                    gender = "hombre";
                    dbValues.Add(gender);
                }
            }

            // Recogemos el valor de la talla. Ya hemos comprobado desde la vista de diseño que solo se puede marcar uno. Comprobamos que hay selección 
            if (lbTshirtSize.SelectedIndex > -1)
            {
                shirtSize = lbTshirtSize.SelectedItem.ToString();
                dbValues.Add(shirtSize);
            } else
            {
                AlertEntryError(lblTshirtSize.Text);
            }

            // Recogemos el nombre para mostrar en la camiseta. Ya hemos controlado en la vista de diseño la longitud máxima de 15.
            if (!string.IsNullOrWhiteSpace(tbTshirtName.Text))
            {
                shirtName = tbTshirtName.Text;
                dbValues.Add(shirtName);
            } else
            {
                AlertEntryError(lblTshirtName.Text);
            }

            // Recogemos los valores de Inscripción Solidaria y Recibir Noticias
            if (cbNonProfit.Checked)
            {
                nonForProfit = YES;
                dbValues.Add(nonForProfit);
            } else
            {
                dbValues.Add(nonForProfit);
            }
            if (cbSendNews.Checked)
            {
                news = YES;
                dbValues.Add(news);
            } else
            {
                dbValues.Add(news);
            }

            // Comprobamos si se ha introducido una nota del examen
            if (!string.IsNullOrWhiteSpace(tbExamenDI.Text))
            {
                calification = tbExamenDI.Text;
                //dbValues.Add(shirtName);
            }
            else
            {
                AlertEntryError(lblExamen.Text);
            }
        }


        /**
         El método isValidId() devuelve true si el dni o nie introducidos son válidos y false en caso contrario
            para ello se validan los patrones y, en función de si es un dni o un nie se calcula la letra 
            que correspondería a esos números. Si la letra encaja se considera válido. Método de elaboracion propia tras 
            consultar varios métodos. Cálculos basados enla página del Ministerio del Interior:
            http://www.interior.gob.es/web/servicios-al-ciudadano/dni/calculo-del-digito-de-control-del-nif-nie
            */
        private Boolean IsValidId(String id)
        {
            
            String correspondencia = "TRWAGMYFPDXBNJZSQVHLCKET";
            Regex dni = new Regex(@"\d{8}[A-Z]$");
            Regex nie = new Regex(@"[X-Z]\d{7}[" + correspondencia + "]$");
            
            // Si el patrón encaja cn dni, entonces calculamos la letra y comprobamos coincidencia
            if (dni.IsMatch(id))
            {
                int dniNumber = Int32.Parse(id.Substring(0, 8));
                int index = dniNumber % 23;
                char dniLetter = Char.Parse(id.Substring(8));
                char expectedLetter = Char.Parse(correspondencia.Substring(index, 1));
                if (expectedLetter == dniLetter)
                {
                    return true;
                } else
                {
                    return false;
                }
            } else // si no encaja con el caso más habitual que es el dni, comprobamos si encaja con nie
            {
                if (nie.IsMatch(id))
                {
                    int nieNumber = Int32.Parse(id.Substring(1, 7));
                    char nieFirstLetter = Char.Parse(id.Substring(0, 1));
                    switch (nieFirstLetter)
                    {
                        case 'X':
                            break;
                        case 'Y':
                            nieNumber += 10000000;
                            break;
                        case 'Z':
                            nieNumber += 20000000;
                            break;
                    }
                    int nieIndex = nieNumber % 23;
                    char nieLetter = Char.Parse(id.Substring(8));
                    char expectedLetter = Char.Parse(correspondencia.Substring(nieIndex, 1));
                    if (expectedLetter == nieLetter)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }

            // si no encaja con ninguno de ambos, entonces no es válido
            return false;
        }

        // Método que muestra un mensaje de error indicando el campo que lo genera. Recibe el valor en string de la etiqueta del campo como parámetro
        private void AlertEntryError(String entryLbl)
        {
            MessageBox.Show("El valor de " + entryLbl + " debe ser válido, revise el campo antes de volver a guardar", "Error en los datos introducidos");
        }

        // Método que evalúa si una entrada es nula o está vacía. Recibe el valor en string de la entrada como parámetro
        private Boolean IsValidEntry(String entry)
        {
            if (entry != null && entry.Length > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        /** Método que evalúa si un email es válido
            Siguiendo las indicaciones de: https://docs.microsoft.com/es-es/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
            */
        private static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }


        // Método que evalúa si un teléfono contiene solo números y su longitud es de 9 dígitos
        private Boolean IsValidPhone(String entry)
        {
            Regex phone = new Regex(@"^?[6789]\d{8}$");
            if (phone.IsMatch(entry))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // Método que evalúa si un Código Postal es válido según se ajuste a la expresión
        private Boolean IsValidZip(String entry)
        {
            Regex zip = new Regex(@"^(?:0[1-9]|[1-4]\d|5[0-2])\d{3}$");
            if (zip.IsMatch(entry))
            {
                return true;
            } else
            {
                return false;
            }
        }

        // Método para controlar que es mayor de edad
        private Boolean IsAdult(int years)
        {
            if (years > 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /** Método para calcular la edad. Lo usamos para pasar el int years al método isAdult como parámetro
            Obtenido de: https://social.msdn.microsoft.com/Forums/vstudio/en-US/d47805d1-6e2e-4a83-a831-37d182276018/c-calculate-age?forum=csharpgeneral */
        private static int CalculateAge(DateTime birthDay)
        {
            int years = DateTime.Now.Year - birthDay.Year;

            if ((birthDay.Month > DateTime.Now.Month) || (birthDay.Month == DateTime.Now.Month && birthDay.Day > DateTime.Now.Day))
                years--;

            return years;
        }

        // Método para verificar la marca habitual del corredor/a. Devuelve 0 si no se ha introducido nada o no es un número. Devuelve el valor como int si es válido
        private int IsValidRecord(String entry)
        {
            int validRecord = 0;
            if (!string.IsNullOrWhiteSpace(entry))
            {
                if (int.TryParse(entry, out int result))
                {
                    return result;
                } else
                {
                    return validRecord;
                }
            }

            return validRecord;
        }

        private void TabSearchEdit_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'runnersDataSet.Runners' Puede moverla o quitarla según sea necesario.
            this.runnersTableAdapter.Fill(this.runnersDataSet.Runners);

        }

    }
}
