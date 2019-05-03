package com.pera.perakasa;

import android.content.Context;
import android.content.pm.PackageManager;

public class Kontrol {
    private boolean kameraKontrolEt(Context context) {
        if (context.getPackageManager().hasSystemFeature(PackageManager.FEATURE_CAMERA)){
            // this device has a camera
            return true;
        } else {
            // no camera on this device
            return false;
        }
    }
}
