﻿namespace R3;

public static class UnoProviderInitializer
{
    public static void SetDefaultObservableSystem(Action<Exception>? unhandledExceptionHandler = null)
    {
        if (unhandledExceptionHandler is not null)
        {
            ObservableSystem.RegisterUnhandledExceptionHandler(unhandledExceptionHandler);
        }

        ObservableSystem.DefaultTimeProvider = new UnoDispatcherTimerProvider();
        ObservableSystem.DefaultFrameProvider = new UnoRenderingFrameProvider();
    }
}
