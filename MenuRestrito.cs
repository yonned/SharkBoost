using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.CodeDom.Compiler;
using System.Collections;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Diagnostics;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using System.Windows.Forms;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using System.Threading;


namespace OtimizaçãoCésar
{
    public partial class MenuRestrito : Form
    {
        public MenuRestrito()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string directoryPath = "C:\\Windows\\Temp"; // Substitua pelo caminho do diretório que você deseja limpar

            try
            {
                DirectoryInfo directory = new DirectoryInfo(directoryPath);

                // Percorre todos os arquivos dentro do diretório
                foreach (FileInfo file in directory.GetFiles())
                {
                    // Ignora arquivos que você não deseja excluir
                    if (file.Name != "arquivo_a_ser_ignorado.txt")
                    {
                        try
                        {
                            file.Delete();
                        }
                        catch (IOException ex)
                        {
                            // Trata o erro, se necessário
                            Console.WriteLine($"Erro ao excluir o arquivo {file.Name}: {ex.Message}");
                        }
                    }
                }

                // Percorre todos os diretórios dentro do diretório
                foreach (DirectoryInfo subDirectory in directory.GetDirectories())
                {
                    // Ignora diretórios que você não deseja excluir
                    if (subDirectory.Name != "diretorio_a_ser_ignorado")
                    {
                        try
                        {
                            subDirectory.Delete(true);
                        }
                        catch (IOException ex)
                        {
                            // Trata o erro, se necessário
                            Console.WriteLine($"Erro ao excluir o diretório {subDirectory.Name}: {ex.Message}");
                        }
                    }
                }

                MessageBox.Show("Conteúdo excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir o conteúdo: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string tempFolderPath = Path.GetTempPath();

                if (Directory.Exists(tempFolderPath))
                {
                    DirectoryInfo tempDirectory = new DirectoryInfo(tempFolderPath);

                    foreach (FileInfo file in tempDirectory.GetFiles())
                    {
                        try
                        {
                            file.Delete();
                        }
                        catch (Exception ex)
                        {
                            // Ignorar arquivo que não pode ser excluído
                            Console.WriteLine($"Erro ao excluir o arquivo {file.Name}: {ex.Message}");
                        }
                    }

                    foreach (DirectoryInfo subdirectory in tempDirectory.GetDirectories())
                    {
                        try
                        {
                            subdirectory.Delete(true);
                        }
                        catch (Exception ex)
                        {
                            // Ignorar diretório que não pode ser excluído
                            Console.WriteLine($"Erro ao excluir o diretório {subdirectory.Name}: {ex.Message}");
                        }
                    }

                    MessageBox.Show("A pasta Temp foi limpa com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao limpar a pasta Temp: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string recycleBinFolderPath = Path.Combine(Path.GetPathRoot(Environment.SystemDirectory), "$Recycle.Bin");

                if (Directory.Exists(recycleBinFolderPath))
                {
                    DirectoryInfo recycleBinDirectory = new DirectoryInfo(recycleBinFolderPath);

                    foreach (DirectoryInfo userDirectory in recycleBinDirectory.GetDirectories())
                    {
                        foreach (FileInfo file in userDirectory.GetFiles())
                        {
                            file.Delete();
                        }

                        foreach (DirectoryInfo subdirectory in userDirectory.GetDirectories())
                        {
                            subdirectory.Delete(true);
                        }
                    }

                    MessageBox.Show("A Lixeira de todos os usuários foi esvaziada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao esvaziar a Lixeira: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string prefetchFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "Prefetch");

                if (Directory.Exists(prefetchFolderPath))
                {
                    DirectoryInfo prefetchDirectory = new DirectoryInfo(prefetchFolderPath);

                    foreach (FileInfo file in prefetchDirectory.GetFiles())
                    {
                        file.Delete();
                    }

                    MessageBox.Show("A pasta Prefetch foi limpa com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao limpar a pasta Prefetch: {ex.Message}");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("dfrgui");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string pastaDownloads = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";

            try
            {
                // Confirmação para o usuário antes de excluir
                var resposta = MessageBox.Show("Tem certeza de que deseja excluir todo o conteúdo da pasta Downloads?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resposta == DialogResult.Yes)
                {
                    // Excluir todo o conteúdo da pasta Downloads
                    Process.Start("cmd.exe", $"/c del /s /q \"{pastaDownloads}\\*.*\"");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir o conteúdo da pasta Downloads: " + ex.Message);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Codigo onde ensina o usuário à otimizar seu pc:

            try
            {
                Process.Start("control.exe", "sysdm.cpl");
                MessageBox.Show("- Vá em avançado!\r\n- Vá em Desempenho > Configurações\r\n- Alterar para \"Ajustar para Obter o Melhor Desempenho\"");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir as propriedades do sistema: {ex.Message}");
            }


        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Execução do arquivo .reg estipulado:
            string username = Environment.UserName;
            string regFileName = "lowlatency.reg";
            string regFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), regFileName);

            try
            {
                System.Diagnostics.Process.Start("regedit.exe", $"/s \"{regFilePath}\"");
                MessageBox.Show("Arquivo .reg executado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao executar o arquivo .reg: {ex.Message}");
            }


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("reg", "add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\WindowsUpdate\\Auto Update\" /v AUOptions /t REG_DWORD /d 1 /f");
            MessageBox.Show(
                        "Incrível amigo, seu pc tá mais firme",
                        "Verificado!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                        "Incrível amigo, seu pc tá melhorando, agradeço pela vez!",
                        "Desligando... zzz!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

            //Finalização do programa:
            this.Close();
        }

        private void MenuRestrito_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Process.Start("powercfg", "/s 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c");
            MessageBox.Show(
                        "Incrível amigo, seu pc tá gastando mais energia!",
                        "Desativado!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\Windows Error Reporting", "Disabled", 1, RegistryValueKind.DWord);
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/c net.exe stop WSearch");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects", "VisualFXSetting", 2, RegistryValueKind.DWord);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/c sc config <nome_do_serviço> start=disabled");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (opSim.Checked)
            {
                MessageBox.Show("Seu resultado é sim, aproveite!", "Fico feliz <3", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (opNao.Checked)
            {
                MessageBox.Show("Seu resultado é não, Sinto muito, espero que na próxima versão ou em outra forma eu possa estar te ajudando <3!", "Perdão..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void opNao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            string targetFolder = @"C:\Windows\SoftwareDistribution\Download"; // Substitua pelo caminho da pasta que você deseja excluir.

            if (Directory.Exists(targetFolder))
            {
                DeleteFolder(targetFolder);
                Console.WriteLine($"Pasta {targetFolder} excluída com sucesso.");
            }
            else
            {
                Console.WriteLine($"A pasta {targetFolder} não existe.");
            }
        }
        public static void DeleteFolder(string folderPath)
        {
            try
            {
                Directory.Delete(folderPath, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao excluir a pasta: {ex.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            string nomeDoArquivoPDF = "CesarCurriculum.pdf";
            string pastaDoPrograma = Path.GetDirectoryName(Application.ExecutablePath);
            string caminhoDoPDF = Path.Combine(pastaDoPrograma, nomeDoArquivoPDF);

            try
            {
                // Verifica se o arquivo PDF existe
                if (File.Exists(caminhoDoPDF))
                {
                    // Abre o PDF com o leitor padrão do sistema
                    Process.Start(caminhoDoPDF);
                }
                else
                {
                    MessageBox.Show("O arquivo do currículo em PDF não foi encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o PDF: " + ex.Message);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string perfilLinkedIn = "https://www.linkedin.com/in/c%C3%A9sar-rodrigues-ribeiro-229b65282/";

            try
            {
                // Especifica que o link é uma URL para abrir no navegador padrão
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = perfilLinkedIn,
                    UseShellExecute = true
                };

                // Abre o link usando o navegador padrão do usuário
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao abrir o LinkedIn: " + ex.Message);
            }
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Abra a chave do Registro que controla as atualizações do Windows
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\", true))
                {
                    if (key != null)
                    {
                        // Tente desativar as atualizações definindo o valor DisableWindowsUpdateAccess a 1
                        key.SetValue("DisableWindowsUpdateAccess", 1, RegistryValueKind.DWord);
                        MessageBox.Show("As atualizações do Windows foram desativadas (hipoteticamente).");
                    }
                    else
                    {
                        MessageBox.Show("A chave do Registro não foi encontrada. Verifique as permissões ou a versão do Windows.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar desativar as atualizações: " + ex.Message);
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("control.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o Painel de Controle: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("taskmgr.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o Gerenciador de Tarefas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}



