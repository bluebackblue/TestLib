
@REM 削除。
RMDIR /S /Q "Assets\UPM\Samples~"

XCOPY "Assets\Samples\TestLib" "Assets\UPM\Samples~\" /E /Y

@PAUSE