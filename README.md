# Benchmark
Allow user to test which binary and which CPU is the fastest

documentation will be constructed soon.

## API
`public frmMain(string file, string compiler, string lang)`

`string file` A file

`string compiler` 3-4 letter either `gcc`,`icc`&`msvc`

`string lang` ISO 639-2B language code

## Application
Change `Class Library` to `Windows Application` and run under arguments, example:
```
C:\>holobenchmark.exe eng gcc F:\video\kawaii.mp4
```

This require `MediaInfo.dll` also IFME `plugins`

## License
Part of GNU GPL v2