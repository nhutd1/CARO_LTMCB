using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;
using System.Windows.Forms;

namespace CARO_LTMCB
{
    class AudioPlayer
    {
        private static WaveOutEvent waveOut;
        private static Mp3FileReader mp3Reader;

        public static void PlayAudio(string audioFileName)
        {
            if (waveOut == null || waveOut.PlaybackState != PlaybackState.Playing)
            {
                if (waveOut != null)
                {
                    waveOut.Dispose();
                    mp3Reader.Dispose();
                }

                // Lấy tệp âm thanh từ tài nguyên của ứng dụng
                byte[] audioBytes = (byte[])Properties.Resources.ResourceManager.GetObject(audioFileName);

                // Kiểm tra xem tệp âm thanh có tồn tại không
                if (audioBytes != null)
                {
                    // Tạo luồng từ mảng byte của tệp âm thanh
                    var audioStream = new System.IO.MemoryStream(audioBytes);

                    // Khởi tạo Mp3FileReader từ luồng âm thanh
                    mp3Reader = new Mp3FileReader(audioStream);

                    // Khởi tạo WaveOutEvent và bắt đầu phát âm thanh
                    waveOut = new WaveOutEvent();
                    waveOut.Init(mp3Reader);
                    waveOut.Play();
                }
                else
                {
                    // Nếu tệp âm thanh không tồn tại, hiển thị thông báo lỗi
                    MessageBox.Show($"Không tìm thấy tệp âm thanh '{audioFileName}.mp3'.");
                }
            }
        }

        public static void StopAudio()
        {
            if (waveOut != null && (waveOut.PlaybackState == PlaybackState.Playing || waveOut.PlaybackState == PlaybackState.Paused))
            {
                waveOut.Stop();
                waveOut.Dispose();
                mp3Reader.Dispose();
            }
        }
    }
}
