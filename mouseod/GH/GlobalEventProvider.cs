using System;
using System.ComponentModel;
using System.Windows.Forms;
using Gma.UserActivityMonitor;

namespace Curvimeter.GH
{
    /// <summary>
    /// This component monitors all mouse activities globally (also outside of the application) 
    /// and provides appropriate events.
    /// </summary>
    public class GlobalEventProvider : Component
    {
        /// <summary>
        /// This component raises events. The value is always true.
        /// </summary>
        protected override bool CanRaiseEvents => true;

        //################################################################
        #region Mouse events

        private event MouseEventHandler MMouseMove;

        /// <summary>
        /// Occurs when the mouse pointer is moved. 
        /// </summary>
        public event MouseEventHandler MouseMove
        {
            add
            {
                if (MMouseMove == null)
                {
                    HookManager.MouseMove += HookManager_MouseMove;
                }
                MMouseMove += value;
            }

            remove
            {
                MMouseMove -= value;
                if (MMouseMove == null)
                {
                    HookManager.MouseMove -= HookManager_MouseMove;
                }
            }
        }

        private void HookManager_MouseMove(object sender, MouseEventArgs e)
        {
            MMouseMove?.Invoke(this, e);
        }

        private event MouseEventHandler MMouseClick;
        /// <summary>
        /// Occurs when a click was performed by the mouse. 
        /// </summary>
        public event MouseEventHandler MouseClick
        {
            add
            {
                if (MMouseClick == null)
                {
                    HookManager.MouseClick += HookManager_MouseClick;
                }
                MMouseClick += value;
            }

            remove
            {
                MMouseClick -= value;
                if (MMouseClick == null)
                {
                    HookManager.MouseClick -= HookManager_MouseClick;
                }
            }
        }

        private void HookManager_MouseClick(object sender, MouseEventArgs e)
        {
            MMouseClick?.Invoke(this, e);
        }

        private event MouseEventHandler MMouseDown;

        /// <summary>
        /// Occurs when the mouse a mouse button is pressed. 
        /// </summary>
        public event MouseEventHandler MouseDown
        {
            add
            {
                if (MMouseDown == null)
                {
                    HookManager.MouseDown += HookManager_MouseDown;
                }
                MMouseDown += value;
            }

            remove
            {
                MMouseDown -= value;
                if (MMouseDown == null)
                {
                    HookManager.MouseDown -= HookManager_MouseDown;
                }
            }
        }

        private void HookManager_MouseDown(object sender, MouseEventArgs e)
        {
            MMouseDown?.Invoke(this, e);
        }


        private event MouseEventHandler MMouseUp;

        /// <summary>
        /// Occurs when a mouse button is released. 
        /// </summary>
        public event MouseEventHandler MouseUp
        {
            add
            {
                if (MMouseUp == null)
                {
                    HookManager.MouseUp += HookManager_MouseUp;
                }
                MMouseUp += value;
            }

            remove
            {
                MMouseUp -= value;
                if (MMouseUp == null)
                {
                    HookManager.MouseUp -= HookManager_MouseUp;
                }
            }
        }

        private void HookManager_MouseUp(object sender, MouseEventArgs e)
        {
            MMouseUp?.Invoke(this, e);
        }

        private event MouseEventHandler MMouseDoubleClick;

        /// <summary>
        /// Occurs when a double clicked was performed by the mouse. 
        /// </summary>
        public event MouseEventHandler MouseDoubleClick
        {
            add
            {
                if (MMouseDoubleClick == null)
                {
                    HookManager.MouseDoubleClick += HookManager_MouseDoubleClick;
                }
                MMouseDoubleClick += value;
            }

            remove
            {
                MMouseDoubleClick -= value;
                if (MMouseDoubleClick == null)
                {
                    HookManager.MouseDoubleClick -= HookManager_MouseDoubleClick;
                }
            }
        }

        private void HookManager_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MMouseDoubleClick?.Invoke(this, e);
        }


        private event EventHandler<MouseEventExtArgs> MMouseMoveExt;

        /// <summary>
        /// Occurs when the mouse pointer is moved. 
        /// </summary>
        /// <remarks>
        /// This event provides extended arguments of type <see cref="MouseEventArgs"/> enabling you to 
        /// supress further processing of mouse movement in other applications.
        /// </remarks>
        public event EventHandler<MouseEventExtArgs> MouseMoveExt
        {
            add
            {
                if (MMouseMoveExt == null)
                {
                    HookManager.MouseMoveExt += HookManager_MouseMoveExt;
                }
                MMouseMoveExt += value;
            }

            remove
            {
                MMouseMoveExt -= value;
                if (MMouseMoveExt == null)
                {
                    HookManager.MouseMoveExt -= HookManager_MouseMoveExt;
                }
            }
        }

        private void HookManager_MouseMoveExt(object sender, MouseEventExtArgs e)
        {
            MMouseMoveExt?.Invoke(this, e);
        }

        private event EventHandler<MouseEventExtArgs> MMouseClickExt;

        /// <summary>
        /// Occurs when a click was performed by the mouse. 
        /// </summary>
        /// <remarks>
        /// This event provides extended arguments of type <see cref="MouseEventArgs"/> enabling you to 
        /// supress further processing of mouse click in other applications.
        /// </remarks>
        public event EventHandler<MouseEventExtArgs> MouseClickExt
        {
            add
            {
                if (MMouseClickExt == null)
                {
                    HookManager.MouseClickExt += HookManager_MouseClickExt;
                }
                MMouseClickExt += value;
            }

            remove
            {
                MMouseClickExt -= value;
                if (MMouseClickExt == null)
                {
                    HookManager.MouseClickExt -= HookManager_MouseClickExt;
                }
            }
        }

        private void HookManager_MouseClickExt(object sender, MouseEventExtArgs e)
        {
            MMouseClickExt?.Invoke(this, e);
        }


        #endregion

        //################################################################
        #region Keyboard events

        private event KeyPressEventHandler MKeyPress;

        /// <summary>
        /// Occurs when a key is pressed.
        /// </summary>
        /// <remarks>
        /// Key events occur in the following order: 
        /// <list type="number">
        /// <item>KeyDown</item>
        /// <item>KeyPress</item>
        /// <item>KeyUp</item>
        /// </list>
        ///The KeyPress event is not raised by noncharacter keys; however, the noncharacter keys do raise the KeyDown and KeyUp events. 
        ///Use the KeyChar property to sample keystrokes at run time and to consume or modify a subset of common keystrokes. 
        ///To handle keyboard events only in your application and not enable other applications to receive keyboard events, 
        /// set the KeyPressEventArgs.Handled property in your form's KeyPress event-handling method to <b>true</b>. 
        /// </remarks>
        public event KeyPressEventHandler KeyPress
        {
            add
            {
                if (MKeyPress==null)
                {
                    HookManager.KeyPress +=HookManager_KeyPress;
                }
                MKeyPress += value;
            }
            remove
            {
                MKeyPress -= value;
                if (MKeyPress == null)
                {
                    HookManager.KeyPress -= HookManager_KeyPress;
                }
            }
        }

        private void HookManager_KeyPress(object sender, KeyPressEventArgs e)
        {
            MKeyPress?.Invoke(this, e);
        }

        private event KeyEventHandler MKeyUp;

        /// <summary>
        /// Occurs when a key is released. 
        /// </summary>
        public event KeyEventHandler KeyUp
        {
            add
            {
                if (MKeyUp == null)
                {
                    HookManager.KeyUp += HookManager_KeyUp;
                }
                MKeyUp += value;
            }
            remove
            {
                MKeyUp -= value;
                if (MKeyUp == null)
                {
                    HookManager.KeyUp -= HookManager_KeyUp;
                }
            }
        }

        private void HookManager_KeyUp(object sender, KeyEventArgs e)
        {
            MKeyUp?.Invoke(this, e);
        }

        private event KeyEventHandler MKeyDown;

        /// <summary>
        /// Occurs when a key is preseed. 
        /// </summary>
        public event KeyEventHandler KeyDown
        {
            add
            {
                if (MKeyDown == null)
                {
                    HookManager.KeyDown += HookManager_KeyDown;
                }
                MKeyDown += value;
            }
            remove
            {
                MKeyDown -= value;
                if (MKeyDown == null)
                {
                    HookManager.KeyDown -= HookManager_KeyDown;
                }
            }
        }

        private void HookManager_KeyDown(object sender, KeyEventArgs e)
        {
            MKeyDown?.Invoke(this, e);
        }

        #endregion

        
    }
}
