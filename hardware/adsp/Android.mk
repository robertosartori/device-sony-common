# Create symlinks for rfsa libraries.

LOCAL_PATH := $(call my-dir)

include $(SONY_CLEAR_VARS)
LOCAL_MODULE := rfsa_symlinks
LOCAL_MODULE_PATH := $(TARGET_OUT_VENDOR)

library_names := \
    rfsa \

include $(SONY_BUILD_SYMLINKS)
