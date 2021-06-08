using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace OOP_CourseWork
{
    /// <summary>
    /// Форма приветственного окна.
    /// </summary>
    public partial class WelcomeForm : Form
    {
        // Время затухания в миллисекундах
        private const int FadeTime = 100;

        private int _timeBeforeExit;
        private bool _isClosing;
        private double _fadeDelta;

        private WelcomeForm() => InitializeComponent();

        /// <summary>
        /// Создает приветственное окно с автоматическом выходом по истечении заданного времени.
        /// </summary>
        /// <param name="timeBeforeExit">Время в секундах до выхода.</param>
        public WelcomeForm(int timeBeforeExit) : this() => _timeBeforeExit = timeBeforeExit;

        /// <summary>
        /// Проигрывает анимацию проявления при открытии окна.
        /// </summary>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            StartFadeAnimation(false);
        }

        /// <summary>
        /// Проигрывает анимацию затухания при закрытии окна.
        /// </summary>
        protected override void OnClosing(CancelEventArgs e)
        {
            if (Opacity == 0)
            {
                base.OnClosing(e);
                return;
            }

            if (!_isClosing)
            {
                _isClosing = true;

                StartFadeAnimation(true);

                DialogResult = DialogResult.Cancel;
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Проигрывает анимацию, уменьшая или увеличивая непрозрачность формы.
        /// </summary>
        private void StartFadeAnimation(bool fade)
        {
            _fadeDelta = 1.0d / FadeTime * _fadeTimer.Interval * (fade ? -1 : 1);
            _fadeTimer.Start();
        }

        /// <summary>
        /// Закрывает форму при на любой элемент управления.
        /// </summary>
        private void FormMouseClick(object sender, MouseEventArgs e) => this.Close();

        /// <summary>
        /// Закрывает форму нажатии любой клавиши.
        /// </summary>
        private void FormKeyDown(object sender, KeyEventArgs e) => this.Close();

        /// <summary>
        /// Закрывает форму по истечении таймера.
        /// </summary>
        private void ExitTimerTick(object sender, EventArgs e)
        {
            if (--_timeBeforeExit <= 0)
            {
                _exitTmer.Stop();
                Close();
            }
        }

        /// <summary>
        /// Изменяет прозрачность при срабатывании соотвутствующего таймера.
        /// </summary>
        private void FadeTimerTick(object sender, EventArgs e)
        {
            Opacity += _fadeDelta;
            if (Opacity == 0)
            {
                _fadeTimer.Stop();
                Close();
            }
            else if (Opacity == 100)
            {
                _fadeTimer.Stop();
            }
        }
    }
}
