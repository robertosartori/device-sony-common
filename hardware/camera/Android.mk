# Create symlinks for camera libraries. Currently only applicable
# to sdm845 and sm8150 boards.

LOCAL_PATH := $(call my-dir)

ifneq ($(filter sdm845 sm8150 sm8250,$(TARGET_BOARD_PLATFORM)),)

include $(SONY_CLEAR_VARS)
LOCAL_MODULE := camera_symlinks
LOCAL_MODULE_PATH := $(TARGET_OUT_VENDOR)

library_names := \
    camera \

include $(SONY_BUILD_SYMLINKS)

endif
