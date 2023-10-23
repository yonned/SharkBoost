using System;
using System.Diagnostics;
using Microsoft.Win32;

namespace ExemploAbrirConfiguracoesDesempenho
{
    class Program
    {
        static void desempenho(string[] args)
        {
            // Abrir as propriedades do sistema
            Process.Start("sysdm.cpl");

            // Aguardar a janela de propriedades do sistema ser aberta
            // Você pode ajustar o tempo de espera conforme necessário
            System.Threading.Thread.Sleep(2000);

            // Encontrar a chave do Registro correspondente às configurações de tema e desempenho
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects", true))
            {
                if (key != null)
                {
                    // Alterar o valor da chave para "2" (Preferir o desempenho)
                    key.SetValue("VisualFXSetting", 2, RegistryValueKind.DWord);
                }
                else
                {
                    Console.WriteLine("Não foi possível encontrar a chave do Registro.");
                }
            }
        }
    }
}

