# MVVMLightMemoryLeakTextBinding
Project for reproducing a memory leak bug in MVVM Lite

## How to test

Press the button on the start window to open another MVVM Light-based window. When closing that second, there still is a reference to the view, caused by a malfunctioning binding of the property `Text`.

