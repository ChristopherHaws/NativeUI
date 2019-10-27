using GTA.Native;

namespace GTA
{
    public static class GameEx
    {
        /// <summary>
        /// Enables all <see cref="Control"/>s this frame.
        /// </summary>
        public static void EnableAllControlsThisFrame(int index) =>
            Function.Call(Hash.ENABLE_ALL_CONTROL_ACTIONS, index);

        /// <summary>
        /// Disables all <see cref="Control"/>s this frame.
        /// </summary>
        public static void DisableAllControlsThisFrame(int index) =>
            Function.Call(Hash.DISABLE_ALL_CONTROL_ACTIONS, index);
    }
}
