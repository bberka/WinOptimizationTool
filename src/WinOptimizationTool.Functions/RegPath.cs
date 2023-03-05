using System.Drawing.Printing;

namespace WinOptimizationTool.Functions;

public static class RegPath
{
    public static class HKLM
    {
        public static class Software
        {
            public const string Get = "Software";

            public static class Microsoft
            {
                public const string Get = Software.Get + "\\Microsoft";
                public static class Windows_NT
                {
                    public const string Get = Microsoft.Get + "\\Windows NT";
                    public static class CurrentVersion
                    {
                        public const string Get = Windows_NT.Get + "\\CurrentVersion";
                        public static class MultiMedia
                        {
                            public const string Get = CurrentVersion.Get + "\\MultiMedia";
                            public static class SystemProfile
                            {
                                public const string Get = MultiMedia.Get + "\\SystemProfile";
                                public static class Tasks
                                {
                                    public const string Get = SystemProfile.Get + "\\Tasks";
                                    public static class Games
                                    {
                                        public const string Get = Tasks.Get + "\\Games";
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static class System
        {
            public const string Get = "System";
            public static class CurrentControlSet
            {
                public const string Get = System.Get + "\\CurrentControlSet";
                public static class Control
                {
                    public const string Get = CurrentControlSet.Get + "\\Control";
                    public static class PriorityControl
                    {
                        public const string Get = Control.Get + "\\PriorityControl";
                    }

                }

            }
        }
    }
    public static class HKCU
    {
        public static class Software
        {
            public const string Get = "Software";

            public static class Microsoft
            {

                public const string Get = Software.Get + "\\Microsoft";

                public static class TabletTip
                {
                    public const string Get = Microsoft.Get + "\\TabletTip";

                    public static class _1_7
                    {
                        public const string Get = TabletTip.Get + "\\1.7";
                    }
                }

                public static class Windows
                {
                    public const string Get = Microsoft.Get + "\\Windows";

                    public static class CurrentVersion
                    {
                        public const string Get = Windows.Get + "\\CurrentVersion";

                        public static class PenWorkspace
                        {
                            public const string Get = CurrentVersion.Get + "\\PenWorkspace";
                        }
                    }
                }
            }
        }
        public static class ControlPanel
        {
            public const string Get = "Control Panel";

            public static class Desktop
            {
                public const string Get = ControlPanel.Get + "\\Desktop";


            }
            public static class Mouse
            {
                public const string Get = ControlPanel.Get + "\\Mouse";

            }
            public static class Cursors
            {

                public const string Get = ControlPanel.Get + "\\Cursors";
            }
        }
    }
}