#!/bin/sh

MONOPATH=/Library/Frameworks/Mono.framework/Versions/Current

export DYLD_FALLBACK_LIBRARY_PATH=$MONOPATH/lib:/lib:/usr/lib

xbuild &&
./pygtk-image.py &
exec $MONOPATH/bin/mono --debug ./bin/Debug/buffer-image.exe 
