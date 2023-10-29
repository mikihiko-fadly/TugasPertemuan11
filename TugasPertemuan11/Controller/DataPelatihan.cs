using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasPertemuan11.Controller
{
    internal class DataPelatihan : Model.Connection
    {
        public DataTable tampilPeserta(MySqlCommand mySqlCommand)
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM peserta";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public void tambahPeserta(string idpeserta, string namapeserta, string email, string notelp)
        {
            string tambah = "INSERT INTO peserta VALUES(" + "@id_peserta,@nama_peserta,@email,@notelp)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_peserta", MySqlConnector.MySqlDbType.VarChar).Value = idpeserta;
                cmd.Parameters.Add("@nama_peserta", MySqlConnector.MySqlDbType.VarChar).Value = namapeserta;
                cmd.Parameters.Add("@email", MySqlConnector.MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@notelp", MySqlConnector.MySqlDbType.VarChar).Value = notelp;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("tambah data gagal" + ex.Message);
            }
        }

        public void updatePeserta(string idpeserta, string namapeserta, string email, string notelp)
        {
            string update = "update peserta set " + "nama_peserta=@namapeserta,email=@email,no_telepon=@notelp " +
                "where id=" + idpeserta;

            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = idpeserta;
                cmd.Parameters.Add("@namapeserta", MySqlConnector.MySqlDbType.VarChar).Value = namapeserta;
                cmd.Parameters.Add("@email", MySqlConnector.MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@notelp", MySqlConnector.MySqlDbType.VarChar).Value = notelp;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("data tidak ada" + ex.Message);
            }
        }

        public void hapusPeserta(string idpeserta)
        {
            string hapus = "delete from peserta where Id =" + idpeserta;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(hapus, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = idpeserta;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delete gagal" + ex.Message);
            }
        }



        public DataTable tampilPelatihan(MySqlCommand mySqlCommand)
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM pelatihan";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public void tambahPelatihan(string idpelatihan, string namapelatihan, DateTime mulai, DateTime selesai, string namainstruktur, string lokasi)
        {
            string tambah = "INSERT INTO pelatihan VALUES(" + "@id,@nama,@tgl_mulai,@tgl_selesai,@instruktur,@lokasi)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = idpelatihan;
                cmd.Parameters.Add("@nama", MySqlConnector.MySqlDbType.VarChar).Value = namapelatihan;
                cmd.Parameters.Add("@tgl_mulai", MySqlConnector.MySqlDbType.VarChar).Value = mulai;
                cmd.Parameters.Add("@tgl_selesai", MySqlConnector.MySqlDbType.VarChar).Value = selesai;
                cmd.Parameters.Add("@instruktur", MySqlConnector.MySqlDbType.VarChar).Value = namainstruktur;
                cmd.Parameters.Add("@lokasi", MySqlConnector.MySqlDbType.VarChar).Value = lokasi;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("tambah data gagal" + ex.Message);
            }
        }

        public void updatePelatihan(string idpelatihan, string namapelatihan, DateTime mulai, DateTime selesai, string namainstruktur, string lokasi)
        {
            string update = "update pelatihan set " + "idpelatihan = @id, namapelatihan = @nama, mulai = @tgl_mulai, selesai = @tgl_selesai, namainstruktur = @instruktur, lokasi = @lokasi " +
                "where id=" + idpelatihan;

            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = idpelatihan;
                cmd.Parameters.Add("@nama", MySqlConnector.MySqlDbType.VarChar).Value = namapelatihan;
                cmd.Parameters.Add("@tgl_mulai", MySqlConnector.MySqlDbType.VarChar).Value = mulai;
                cmd.Parameters.Add("@tgl_selesai", MySqlConnector.MySqlDbType.VarChar).Value = selesai;
                cmd.Parameters.Add("@instruktur", MySqlConnector.MySqlDbType.VarChar).Value = namainstruktur;
                cmd.Parameters.Add("@lokasi", MySqlConnector.MySqlDbType.VarChar).Value = lokasi;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("data tidak ada" + ex.Message);
            }
        }

        public void hapusPelatihan(string idpelatihan)
        {
            string hapus = "delete from pelatihan where Id =" + idpelatihan;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(hapus, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = idpelatihan;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delete gagal" + ex.Message);
            }
        }



    }
}
