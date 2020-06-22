﻿using NUnit.Framework;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace LibThreadsTests.Utils
{
    public class PictureBoxTests
    {
        #region Private fields and properties

        private PictureBox _pictureBox;
        private Image _image;
        private Bitmap _bitmap;

        #endregion

        /// <summary>
        /// Setup private fields.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Setup)} start.");

            _pictureBox = new PictureBox();

            var filePng = @"c:\Windows\ImmersiveControlPanel\images\splashscreen.png";
            if (File.Exists(filePng))
            {
                _image = Image.FromFile(filePng);
                _bitmap = (Bitmap)Bitmap.FromFile(filePng);
            }

            TestContext.WriteLine($@"{nameof(Setup)} complete.");
        }

        /// <summary>
        /// Reset private fields to default state.
        /// </summary>
        [TearDown]
        public void Teardown()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Teardown)} start.");
            //
            TestContext.WriteLine($@"{nameof(Teardown)} complete.");
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
        }

        [Test]
        public void Properties_SetBackgroundImage_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Properties_SetBackgroundImage_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            Assert.DoesNotThrow(() => LibThreads.Utils.PictureBox.Properties.SetBackgroundImage.Sync(_pictureBox, _image));
            Assert.DoesNotThrowAsync(() => LibThreads.Utils.PictureBox.Properties.SetBackgroundImage.Async(_pictureBox, _image));

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Properties_SetBackgroundImage_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void Properties_SetBitmap_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Properties_SetBitmap_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            Assert.DoesNotThrow(() => LibThreads.Utils.PictureBox.Properties.SetBitmap.Sync(_pictureBox, _bitmap));
            Assert.DoesNotThrowAsync(() => LibThreads.Utils.PictureBox.Properties.SetBitmap.Async(_pictureBox, _bitmap));

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Properties_SetBitmap_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void Properties_SetImage_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Properties_SetImage_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            Assert.DoesNotThrow(() => LibThreads.Utils.PictureBox.Properties.SetImage.Sync(_pictureBox, _image));
            Assert.DoesNotThrowAsync(() => LibThreads.Utils.PictureBox.Properties.SetImage.Async(_pictureBox, _image));

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Properties_SetImage_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }
    }
}
