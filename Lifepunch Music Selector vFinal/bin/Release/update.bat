
                                                @echo off
                                                del /F "Introsphere Music Selector.exe.pre v1.2 5-1-17"
                                                ren "H:\Introsphere Music Selector\Introsphere-Music-Selector\Lifepunch Music Selector vFinal\bin\Release\Introsphere Music Selector.exe" "Introsphere Music Selector.exe.pre v1.2 5-1-17"
                                                del /F "Introsphere Music Selector.exe"

                                                ren "Introsphere_Music_Selector_v1.2.exe" "Introsphere Music Selector.exe"
                                                start "" "Introsphere Music Selector.exe"