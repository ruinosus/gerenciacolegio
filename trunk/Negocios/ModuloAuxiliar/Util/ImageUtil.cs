using System;
using System.IO;
using System.Drawing;

namespace Negocios.ModuloAuxiliar.Util
{
    /// <summary>
    /// Classe utilitária para se trabalhar com imagens.
    /// @Since: 14/06/2007
    /// </summary>
    public class ImageUtil
    {

        /// <summary>
        /// Reconstroi uma imagem a partir de uma Stream.
        /// </summary>
        /// <param name="stream"></param>
        /// <returns>A imagem reconstruída</returns>
        public static System.Drawing.Image ConvertToImage(Stream stream)
        {
            System.Drawing.Image newImage = System.Drawing.Image.FromStream(stream);

            return newImage;
        }

        /// <summary>
        /// Método para criar miniaturas das Imagens.
        /// </summary>
        /// <param name="stream">FileStream da imagem que se deseja miniaturizar.</param>
        /// <returns>Imagem miniaturizada.</returns>
    /*    public static System.Drawing.Image GetThumbnail(FileStream stream)
        {
            int width = ModuloAuxiliar.Constantes.ConstantesGerais.THUMBNAIL_WIDTH;
            int height = ModuloAuxiliar.Constantes.ConstantesGerais.THUMBNAIL_HEIGHT;

            System.Drawing.Image image = System.Drawing.Image.FromStream(stream);

            // cria o thumbnail do object image, definindo sua altura e largura para os valores das constantes.
            System.Drawing.Image thumbnailImage = image.GetThumbnailImage(width, height, new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero);

            return thumbnailImage;
        }*/

        /// <summary>
        /// Método para criar miniaturas das Imagens.
        /// </summary>
        /// <param name="fileName">Caminho da imagem que se deseja miniaturizar.</param>
        /// <returns>Imagem miniaturizada.</returns>
      /*  public static System.Drawing.Image GetThumbnail(String fileName)
        {
            int width = ModuloAuxiliar.Constantes.ConstantesGerais.THUMBNAIL_WIDTH;
            int height = ModuloAuxiliar.Constantes.ConstantesGerais.THUMBNAIL_HEIGHT;

            System.Drawing.Image image = System.Drawing.Image.FromFile(fileName);

            // cria o thumbnail do object image, definindo sua altura e largura para os valores das constantes.
            System.Drawing.Image thumbnailImage = image.GetThumbnailImage(width, height, new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero);

            return thumbnailImage;
        }

        /// <summary>
        /// Método para criar miniaturas das Imagens.
        /// </summary>
        /// <param name="image">Imagem que se deseja miniaturizar.</param>
        /// <returns>Imagem miniaturizada.</returns>
        public static System.Drawing.Image GetThumbnail(System.Drawing.Image image)
        {
            int width = ModuloAuxiliar.Constantes.ConstantesGerais.THUMBNAIL_WIDTH;
            int height = ModuloAuxiliar.Constantes.ConstantesGerais.THUMBNAIL_HEIGHT;

            // cria o thumbnail do object image, definindo sua altura e largura para os valores das constantes.
            System.Drawing.Image thumbnailImage = image.GetThumbnailImage(width, height, new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero);

            return thumbnailImage;
        }

        /// <summary>
        /// Método para criar miniaturas das Imagens.
        /// </summary>
        /// <param name="image">Imagem que se deseja miniaturizar.</param>
        /// <returns>Imagem miniaturizada.</returns>
        public static System.Drawing.Image GetThumbnail(System.Drawing.Image image, bool TamanhoMedio)
        {
            int width;
            int height;
            if (true)
            {
                width = ModuloAuxiliar.Constantes.ConstantesGerais.THUMBNAILMEDIO_WIDTH;
                height = ModuloAuxiliar.Constantes.ConstantesGerais.THUMBNAILMEDIO_HEIGHT;
            }
            else
            {
                width = ModuloAuxiliar.Constantes.ConstantesGerais.THUMBNAIL_WIDTH;
                height = ModuloAuxiliar.Constantes.ConstantesGerais.THUMBNAIL_HEIGHT;
            }

            // cria o thumbnail do object image, definindo sua altura e largura para os valores das constantes.
            System.Drawing.Image thumbnailImage = image.GetThumbnailImage(width, height, new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero);

            return thumbnailImage;
        }

        /// <summary>
        /// Método privado complementar para os métodos GetThumbnail()
        /// </summary>
        /// <returns>true</returns>
        public static bool ThumbnailCallback()
        {
            return true;
        }

        /// <summary>
        /// Reconstroi uma imagem a partir de um arquivo.
        /// </summary>
        /// <param name="path"></param>
        /// <returns>A imagem reconstruída</returns>
        public static System.Drawing.Image LoadImage(String path)
        {
            System.Drawing.Image newImage = System.Drawing.Image.FromFile(path);

            return newImage;
        }

        /// <summary>
        /// Reconstroi uma imagem a partir de um stream.
        /// </summary>
        /// <param name="stream"></param>
        /// <returns>A imagem reconstruída</returns>
        public static System.Drawing.Image LoadImage(Stream stream)
        {
            System.Drawing.Image newImage = System.Drawing.Image.FromStream(stream);

            return newImage;
        }

        /// <summary>
        /// Reconstroi uma imagem a partir de um array de bytes.
        /// </summary>
        /// <param name="myByteArray"></param>
        /// <returns>A imagem reconstruída</returns>
        public static System.Drawing.Image ConvertByteArrayToImage(Byte[] myByteArray)
        {
            MemoryStream ms = new MemoryStream(myByteArray, 0, myByteArray.Length);
            ms.Write(myByteArray, 0, myByteArray.Length);
            System.Drawing.Image newImage = System.Drawing.Image.FromStream(ms, true);

            return newImage;
        }

        /// <summary>
        /// Método para converter imagem em array de bytes.
        /// </summary>
        /// <param name="imagem">Imagem que será convertida.</param>
        /// <returns>Array de bytes da imagem</returns>
        public static Byte[] ConvertImageToByteArray(System.Drawing.Image imagem)
        {
            //Cria o memory stream para trabalhar com os bytes da imagem.
            MemoryStream imageStream = new MemoryStream();

            //Coloca a imagem no memory stream.
            imagem.Save(imageStream, System.Drawing.Imaging.ImageFormat.Png);

            //Cria um array de bytes com o tamanho da imagem.
            byte[] imageContent = new Byte[imageStream.Length];

            //Rebobina o memory stream.
            imageStream.Position = 0;

            //Carrega o array de bytes com a imagem.
            imageStream.Read(imageContent, 0, (int)imageStream.Length);

            return imageContent;

        }*/

    }
}