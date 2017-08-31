namespace Com.Wdullaer.Materialdatetimepicker.Time
{
    public interface ITimePickerController
    {
        /**
     * @return boolean - true if the dark theme should be used
     */
        bool IsThemeDark { get; }

        /**
         * @return boolean - true if 24 hour mode is used / false if AM/PM is used
         */
        bool Is24HourMode();

        /**
         * @return int - the accent color currently in use
         */
        int AccentColor { get; }

        /**
         * @return Version - The current version to render
         */
        TimePickerDialog.Version GetVersion();

        /**
         * Request the device to vibrate
         */
        void TryVibrate();

        /**
         * @param time Timepoint - the selected point in time
         * @param index int - The current view to consider when calculating the range
         * @return boolean - true if this is not a selectable value
         */
        bool IsOutOfRange(Timepoint time, int index);

        /**
         * @return boolean - true if AM times are outside the range of valid selections
         */
        bool IsAmDisabled { get; }

        /**
         * @return boolean - true if PM times are outside the range of valid selections
         */
        bool IsPmDisabled { get; }

        /**
         * Will round the given Timepoint to the nearest valid Timepoint given the following restrictions:
         *   - TYPE.HOUR, it will just round to the next valid point, possible adjusting minutes and seconds
         *   - TYPE.MINUTE, it will round to the next valid point, without adjusting the hour, but possibly adjusting the seconds
         *   - TYPE.SECOND, it will round to the next valid point, only adjusting the seconds
         * @param time Timepoint - the timepoint to validate
         * @param type Timepoint.TYPE - whether we should round the hours, minutes or seconds
         * @return timepoint - the nearest valid timepoint
         */
        Timepoint RoundToNearest(Timepoint time, Timepoint.TYPE type);
    }
}