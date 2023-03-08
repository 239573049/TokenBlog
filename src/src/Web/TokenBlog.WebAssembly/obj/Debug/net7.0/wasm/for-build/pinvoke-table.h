// GENERATED FILE, DO NOT MODIFY

int CompressionNative_Crc32 (int,int,int);
int CompressionNative_Deflate (int,int);
int CompressionNative_DeflateEnd (int);
int CompressionNative_DeflateInit2_ (int,int,int,int,int,int);
int CompressionNative_Inflate (int,int);
int CompressionNative_InflateEnd (int);
int CompressionNative_InflateInit2_ (int,int);
void GlobalizationNative_ChangeCase (int,int,int,int,int);
void GlobalizationNative_ChangeCaseInvariant (int,int,int,int,int);
void GlobalizationNative_ChangeCaseTurkish (int,int,int,int,int);
void GlobalizationNative_CloseSortHandle (int);
int GlobalizationNative_CompareString (int,int,int,int,int,int);
int GlobalizationNative_EndsWith (int,int,int,int,int,int,int);
int GlobalizationNative_EnumCalendarInfo (int,int,int,int,int);
int GlobalizationNative_GetCalendarInfo (int,int,int,int,int);
int GlobalizationNative_GetCalendars (int,int,int);
int GlobalizationNative_GetDefaultLocaleName (int,int);
int GlobalizationNative_GetICUVersion ();
int GlobalizationNative_GetJapaneseEraStartDate (int,int,int,int);
int GlobalizationNative_GetLatestJapaneseEra ();
int GlobalizationNative_GetLocaleInfoGroupingSizes (int,int,int,int);
int GlobalizationNative_GetLocaleInfoInt (int,int,int);
int GlobalizationNative_GetLocaleInfoString (int,int,int,int,int);
int GlobalizationNative_GetLocaleName (int,int,int);
int GlobalizationNative_GetLocales (int,int);
int GlobalizationNative_GetLocaleTimeFormat (int,int,int,int);
int GlobalizationNative_GetSortHandle (int,int);
int GlobalizationNative_GetSortKey (int,int,int,int,int,int);
int GlobalizationNative_GetSortVersion (int);
int GlobalizationNative_IndexOf (int,int,int,int,int,int,int);
void GlobalizationNative_InitICUFunctions (int,int,int,int);
void GlobalizationNative_InitOrdinalCasingPage (int,int);
int GlobalizationNative_IsNormalized (int,int,int);
int GlobalizationNative_IsPredefinedLocale (int);
int GlobalizationNative_LastIndexOf (int,int,int,int,int,int,int);
int GlobalizationNative_LoadICU ();
int GlobalizationNative_NormalizeString (int,int,int,int,int);
int GlobalizationNative_StartsWith (int,int,int,int,int,int,int);
int GlobalizationNative_ToAscii (int,int,int,int,int);
int GlobalizationNative_ToUnicode (int,int,int,int,int);
void gr_backendrendertarget_delete (int);
int gr_backendrendertarget_get_backend (int);
int gr_backendrendertarget_get_gl_framebufferinfo (int,int);
int gr_backendrendertarget_get_height (int);
int gr_backendrendertarget_get_samples (int);
int gr_backendrendertarget_get_stencils (int);
int gr_backendrendertarget_get_width (int);
int gr_backendrendertarget_is_valid (int);
int gr_backendrendertarget_new_gl (int,int,int,int,int);
int gr_backendrendertarget_new_metal (int,int,int,int);
int gr_backendrendertarget_new_vulkan (int,int,int,int);
void gr_backendtexture_delete (int);
int gr_backendtexture_get_backend (int);
int gr_backendtexture_get_gl_textureinfo (int,int);
int gr_backendtexture_get_height (int);
int gr_backendtexture_get_width (int);
int gr_backendtexture_has_mipmaps (int);
int gr_backendtexture_is_valid (int);
int gr_backendtexture_new_gl (int,int,int,int);
int gr_backendtexture_new_metal (int,int,int,int);
int gr_backendtexture_new_vulkan (int,int,int);
void gr_direct_context_abandon_context (int);
void gr_direct_context_dump_memory_statistics (int,int);
void gr_direct_context_flush (int);
void gr_direct_context_flush_and_submit (int,int);
void gr_direct_context_free_gpu_resources (int);
int gr_direct_context_get_resource_cache_limit (int);
void gr_direct_context_get_resource_cache_usage (int,int,int);
int gr_direct_context_is_abandoned (int);
int gr_direct_context_make_gl (int);
int gr_direct_context_make_gl_with_options (int,int);
int gr_direct_context_make_metal (int,int);
int gr_direct_context_make_metal_with_options (int,int,int);
int gr_direct_context_make_vulkan (int);
int gr_direct_context_make_vulkan_with_options (int,int);
void gr_direct_context_perform_deferred_cleanup (int,int64_t);
void gr_direct_context_purge_unlocked_resources (int,int);
void gr_direct_context_purge_unlocked_resources_bytes (int,int,int);
void gr_direct_context_release_resources_and_abandon_context (int);
void gr_direct_context_reset_context (int,int);
void gr_direct_context_set_resource_cache_limit (int,int);
int gr_direct_context_submit (int,int);
int gr_glinterface_assemble_gl_interface (int,int);
int gr_glinterface_assemble_gles_interface (int,int);
int gr_glinterface_assemble_interface (int,int);
int gr_glinterface_assemble_webgl_interface (int,int);
int gr_glinterface_create_native_interface ();
int gr_glinterface_has_extension (int,int);
void gr_glinterface_unref (int);
int gr_glinterface_validate (int);
int gr_recording_context_get_backend (int);
int gr_recording_context_get_max_surface_sample_count_for_color_type (int,int);
void gr_recording_context_unref (int);
void gr_vk_extensions_delete (int);
int gr_vk_extensions_has_extension (int,int,int);
void gr_vk_extensions_init (int,int,int,int,int,int,int,int,int);
int gr_vk_extensions_new ();
void sk_3dview_apply_to_canvas (int,int);
void sk_3dview_destroy (int);
float sk_3dview_dot_with_normal (int,float,float,float);
void sk_3dview_get_matrix (int,int);
int sk_3dview_new ();
void sk_3dview_restore (int);
void sk_3dview_rotate_x_degrees (int,float);
void sk_3dview_rotate_x_radians (int,float);
void sk_3dview_rotate_y_degrees (int,float);
void sk_3dview_rotate_y_radians (int,float);
void sk_3dview_rotate_z_degrees (int,float);
void sk_3dview_rotate_z_radians (int,float);
void sk_3dview_save (int);
void sk_3dview_translate (int,float,float,float);
void sk_bitmap_destructor (int);
void sk_bitmap_erase (int,int);
void sk_bitmap_erase_rect (int,int,int);
int sk_bitmap_extract_alpha (int,int,int,int);
int sk_bitmap_extract_subset (int,int,int);
int sk_bitmap_get_addr (int,int,int);
int sk_bitmap_get_addr_16 (int,int,int);
int sk_bitmap_get_addr_32 (int,int,int);
int sk_bitmap_get_addr_8 (int,int,int);
int sk_bitmap_get_byte_count (int);
void sk_bitmap_get_info (int,int);
int sk_bitmap_get_pixel_color (int,int,int);
void sk_bitmap_get_pixel_colors (int,int);
int sk_bitmap_get_pixels (int,int);
int sk_bitmap_get_row_bytes (int);
int sk_bitmap_install_mask_pixels (int,int);
int sk_bitmap_install_pixels (int,int,int,int,int,int);
int sk_bitmap_install_pixels_with_pixmap (int,int);
int sk_bitmap_is_immutable (int);
int sk_bitmap_is_null (int);
int sk_bitmap_make_shader (int,int,int,int);
int sk_bitmap_new ();
void sk_bitmap_notify_pixels_changed (int);
int sk_bitmap_peek_pixels (int,int);
int sk_bitmap_ready_to_draw (int);
void sk_bitmap_reset (int);
void sk_bitmap_set_immutable (int);
void sk_bitmap_set_pixels (int,int);
void sk_bitmap_swap (int,int);
int sk_bitmap_try_alloc_pixels (int,int,int);
int sk_bitmap_try_alloc_pixels_with_flags (int,int,int);
void sk_canvas_clear (int,int);
void sk_canvas_clear_color4f (int,int);
void sk_canvas_clip_path_with_operation (int,int,int,int);
void sk_canvas_clip_rect_with_operation (int,int,int,int);
void sk_canvas_clip_region (int,int,int);
void sk_canvas_clip_rrect_with_operation (int,int,int,int);
void sk_canvas_concat (int,int);
void sk_canvas_destroy (int);
void sk_canvas_discard (int);
void sk_canvas_draw_annotation (int,int,int,int);
void sk_canvas_draw_arc (int,int,float,float,int,int);
void sk_canvas_draw_atlas (int,int,int,int,int,int,int,int,int);
void sk_canvas_draw_circle (int,float,float,float,int);
void sk_canvas_draw_color (int,int,int);
void sk_canvas_draw_color4f (int,int,int);
void sk_canvas_draw_drawable (int,int,int);
void sk_canvas_draw_drrect (int,int,int,int);
void sk_canvas_draw_image (int,int,float,float,int);
void sk_canvas_draw_image_lattice (int,int,int,int,int);
void sk_canvas_draw_image_nine (int,int,int,int,int);
void sk_canvas_draw_image_rect (int,int,int,int,int);
void sk_canvas_draw_line (int,float,float,float,float,int);
void sk_canvas_draw_link_destination_annotation (int,int,int);
void sk_canvas_draw_named_destination_annotation (int,int,int);
void sk_canvas_draw_oval (int,int,int);
void sk_canvas_draw_paint (int,int);
void sk_canvas_draw_patch (int,int,int,int,int,int);
void sk_canvas_draw_path (int,int,int);
void sk_canvas_draw_picture (int,int,int,int);
void sk_canvas_draw_point (int,float,float,int);
void sk_canvas_draw_points (int,int,int,int,int);
void sk_canvas_draw_rect (int,int,int);
void sk_canvas_draw_region (int,int,int);
void sk_canvas_draw_round_rect (int,int,float,float,int);
void sk_canvas_draw_rrect (int,int,int);
void sk_canvas_draw_simple_text (int,int,int,int,float,float,int,int);
void sk_canvas_draw_text_blob (int,int,float,float,int);
void sk_canvas_draw_url_annotation (int,int,int);
void sk_canvas_draw_vertices (int,int,int,int);
void sk_canvas_flush (int);
int sk_canvas_get_device_clip_bounds (int,int);
int sk_canvas_get_local_clip_bounds (int,int);
int sk_canvas_get_save_count (int);
void sk_canvas_get_total_matrix (int,int);
int sk_canvas_is_clip_empty (int);
int sk_canvas_is_clip_rect (int);
int sk_canvas_new_from_bitmap (int);
int sk_canvas_quick_reject (int,int);
void sk_canvas_reset_matrix (int);
void sk_canvas_restore (int);
void sk_canvas_restore_to_count (int,int);
void sk_canvas_rotate_degrees (int,float);
void sk_canvas_rotate_radians (int,float);
int sk_canvas_save (int);
int sk_canvas_save_layer (int,int,int);
void sk_canvas_scale (int,float,float);
void sk_canvas_set_matrix (int,int);
void sk_canvas_skew (int,float,float);
void sk_canvas_translate (int,float,float);
void sk_codec_destroy (int);
int sk_codec_get_encoded_format (int);
int sk_codec_get_frame_count (int);
void sk_codec_get_frame_info (int,int);
int sk_codec_get_frame_info_for_index (int,int,int);
void sk_codec_get_info (int,int);
int sk_codec_get_origin (int);
int sk_codec_get_pixels (int,int,int,int,int);
int sk_codec_get_repetition_count (int);
void sk_codec_get_scaled_dimensions (int,float,int);
int sk_codec_get_scanline_order (int);
int sk_codec_get_scanlines (int,int,int,int);
int sk_codec_get_valid_subset (int,int);
int sk_codec_incremental_decode (int,int);
int sk_codec_min_buffered_bytes_needed ();
int sk_codec_new_from_data (int);
int sk_codec_new_from_stream (int,int);
int sk_codec_next_scanline (int);
int sk_codec_output_scanline (int,int);
int sk_codec_skip_scanlines (int,int);
int sk_codec_start_incremental_decode (int,int,int,int,int);
int sk_codec_start_scanline_decode (int,int,int);
void sk_color_get_bit_shift (int,int,int,int);
int sk_color_premultiply (int);
void sk_color_premultiply_array (int,int,int);
int sk_color_unpremultiply (int);
void sk_color_unpremultiply_array (int,int,int);
void sk_color4f_from_color (int,int);
int sk_color4f_to_color (int);
int sk_colorfilter_new_color_matrix (int);
int sk_colorfilter_new_compose (int,int);
int sk_colorfilter_new_high_contrast (int);
int sk_colorfilter_new_lighting (int,int);
int sk_colorfilter_new_luma_color ();
int sk_colorfilter_new_mode (int,int);
int sk_colorfilter_new_table (int);
int sk_colorfilter_new_table_argb (int,int,int,int);
void sk_colorfilter_unref (int);
int sk_colorspace_equals (int,int);
int sk_colorspace_gamma_close_to_srgb (int);
int sk_colorspace_gamma_is_linear (int);
void sk_colorspace_icc_profile_delete (int);
int sk_colorspace_icc_profile_get_buffer (int,int);
int sk_colorspace_icc_profile_get_to_xyzd50 (int,int);
int sk_colorspace_icc_profile_new ();
int sk_colorspace_icc_profile_parse (int,int,int);
int sk_colorspace_is_numerical_transfer_fn (int,int);
int sk_colorspace_is_srgb (int);
int sk_colorspace_make_linear_gamma (int);
int sk_colorspace_make_srgb_gamma (int);
int sk_colorspace_new_icc (int);
int sk_colorspace_new_rgb (int,int);
int sk_colorspace_new_srgb ();
int sk_colorspace_new_srgb_linear ();
int sk_colorspace_primaries_to_xyzd50 (int,int);
void sk_colorspace_ref (int);
void sk_colorspace_to_profile (int,int);
int sk_colorspace_to_xyzd50 (int,int);
float sk_colorspace_transfer_fn_eval (int,float);
int sk_colorspace_transfer_fn_invert (int,int);
void sk_colorspace_transfer_fn_named_2dot2 (int);
void sk_colorspace_transfer_fn_named_hlg (int);
void sk_colorspace_transfer_fn_named_linear (int);
void sk_colorspace_transfer_fn_named_pq (int);
void sk_colorspace_transfer_fn_named_rec2020 (int);
void sk_colorspace_transfer_fn_named_srgb (int);
void sk_colorspace_unref (int);
void sk_colorspace_xyz_concat (int,int,int);
int sk_colorspace_xyz_invert (int,int);
void sk_colorspace_xyz_named_adobe_rgb (int);
void sk_colorspace_xyz_named_display_p3 (int);
void sk_colorspace_xyz_named_rec2020 (int);
void sk_colorspace_xyz_named_srgb (int);
void sk_colorspace_xyz_named_xyz (int);
int sk_colortable_count (int);
int sk_colortable_new (int,int);
void sk_colortable_read_colors (int,int);
void sk_colortable_unref (int);
int sk_colortype_get_default_8888 ();
int sk_compatpaint_clone (int);
void sk_compatpaint_delete (int);
int sk_compatpaint_get_font (int);
int sk_compatpaint_get_text_align (int);
int sk_compatpaint_get_text_encoding (int);
int sk_compatpaint_make_font (int);
int sk_compatpaint_new ();
int sk_compatpaint_new_with_font (int);
void sk_compatpaint_reset (int);
void sk_compatpaint_set_text_align (int,int);
void sk_compatpaint_set_text_encoding (int,int);
int sk_data_get_bytes (int);
int sk_data_get_data (int);
int sk_data_get_size (int);
int sk_data_new_empty ();
int sk_data_new_from_file (int);
int sk_data_new_from_stream (int,int);
int sk_data_new_subset (int,int,int);
int sk_data_new_uninitialized (int);
int sk_data_new_with_copy (int,int);
int sk_data_new_with_proc (int,int,int,int);
void sk_data_ref (int);
void sk_data_unref (int);
void sk_document_abort (int);
int sk_document_begin_page (int,float,float,int);
void sk_document_close (int);
int sk_document_create_pdf_from_stream (int);
int sk_document_create_pdf_from_stream_with_metadata (int,int);
int sk_document_create_xps_from_stream (int,float);
void sk_document_end_page (int);
void sk_document_unref (int);
void sk_drawable_draw (int,int,int);
void sk_drawable_get_bounds (int,int);
int sk_drawable_get_generation_id (int);
int sk_drawable_new_picture_snapshot (int);
void sk_drawable_notify_drawing_changed (int);
void sk_drawable_unref (int);
void sk_dynamicmemorywstream_copy_to (int,int);
void sk_dynamicmemorywstream_destroy (int);
int sk_dynamicmemorywstream_detach_as_data (int);
int sk_dynamicmemorywstream_detach_as_stream (int);
int sk_dynamicmemorywstream_new ();
int sk_dynamicmemorywstream_write_to_stream (int,int);
void sk_filestream_destroy (int);
int sk_filestream_is_valid (int);
int sk_filestream_new (int);
void sk_filewstream_destroy (int);
int sk_filewstream_is_valid (int);
int sk_filewstream_new (int);
int sk_font_break_text (int,int,int,int,float,int,int);
void sk_font_delete (int);
int sk_font_get_edging (int);
int sk_font_get_hinting (int);
float sk_font_get_metrics (int,int);
int sk_font_get_path (int,int,int);
void sk_font_get_paths (int,int,int,int,int);
void sk_font_get_pos (int,int,int,int,int);
float sk_font_get_scale_x (int);
float sk_font_get_size (int);
float sk_font_get_skew_x (int);
int sk_font_get_typeface (int);
void sk_font_get_widths_bounds (int,int,int,int,int,int);
void sk_font_get_xpos (int,int,int,int,float);
int sk_font_is_baseline_snap (int);
int sk_font_is_embedded_bitmaps (int);
int sk_font_is_embolden (int);
int sk_font_is_force_auto_hinting (int);
int sk_font_is_linear_metrics (int);
int sk_font_is_subpixel (int);
float sk_font_measure_text (int,int,int,int,int,int);
void sk_font_measure_text_no_return (int,int,int,int,int,int,int);
int sk_font_new ();
int sk_font_new_with_values (int,float,float,float);
void sk_font_set_baseline_snap (int,int);
void sk_font_set_edging (int,int);
void sk_font_set_embedded_bitmaps (int,int);
void sk_font_set_embolden (int,int);
void sk_font_set_force_auto_hinting (int,int);
void sk_font_set_hinting (int,int);
void sk_font_set_linear_metrics (int,int);
void sk_font_set_scale_x (int,float);
void sk_font_set_size (int,float);
void sk_font_set_skew_x (int,float);
void sk_font_set_subpixel (int,int);
void sk_font_set_typeface (int,int);
int sk_font_text_to_glyphs (int,int,int,int,int,int);
int sk_font_unichar_to_glyph (int,int);
void sk_font_unichars_to_glyphs (int,int,int,int);
int sk_fontmgr_count_families (int);
int sk_fontmgr_create_default ();
int sk_fontmgr_create_from_data (int,int,int);
int sk_fontmgr_create_from_file (int,int,int);
int sk_fontmgr_create_from_stream (int,int,int);
int sk_fontmgr_create_styleset (int,int);
void sk_fontmgr_get_family_name (int,int,int);
int sk_fontmgr_match_face_style (int,int,int);
int sk_fontmgr_match_family (int,int);
int sk_fontmgr_match_family_style (int,int,int);
int sk_fontmgr_match_family_style_character (int,int,int,int,int,int);
int sk_fontmgr_ref_default ();
void sk_fontmgr_unref (int);
void sk_fontstyle_delete (int);
int sk_fontstyle_get_slant (int);
int sk_fontstyle_get_weight (int);
int sk_fontstyle_get_width (int);
int sk_fontstyle_new (int,int,int);
int sk_fontstyleset_create_empty ();
int sk_fontstyleset_create_typeface (int,int);
int sk_fontstyleset_get_count (int);
void sk_fontstyleset_get_style (int,int,int,int);
int sk_fontstyleset_match_style (int,int);
void sk_fontstyleset_unref (int);
void sk_graphics_dump_memory_statistics (int);
int sk_graphics_get_font_cache_count_limit ();
int sk_graphics_get_font_cache_count_used ();
int sk_graphics_get_font_cache_limit ();
int sk_graphics_get_font_cache_point_size_limit ();
int sk_graphics_get_font_cache_used ();
int sk_graphics_get_resource_cache_single_allocation_byte_limit ();
int sk_graphics_get_resource_cache_total_byte_limit ();
int sk_graphics_get_resource_cache_total_bytes_used ();
void sk_graphics_init ();
void sk_graphics_purge_all_caches ();
void sk_graphics_purge_font_cache ();
void sk_graphics_purge_resource_cache ();
int sk_graphics_set_font_cache_count_limit (int);
int sk_graphics_set_font_cache_limit (int);
int sk_graphics_set_font_cache_point_size_limit (int);
int sk_graphics_set_resource_cache_single_allocation_byte_limit (int);
int sk_graphics_set_resource_cache_total_byte_limit (int);
int sk_image_encode (int);
int sk_image_encode_specific (int,int,int);
int sk_image_get_alpha_type (int);
int sk_image_get_color_type (int);
int sk_image_get_colorspace (int);
int sk_image_get_height (int);
int sk_image_get_unique_id (int);
int sk_image_get_width (int);
int sk_image_is_alpha_only (int);
int sk_image_is_lazy_generated (int);
int sk_image_is_texture_backed (int);
int sk_image_is_valid (int,int);
int sk_image_make_non_texture_image (int);
int sk_image_make_raster_image (int);
int sk_image_make_shader (int,int,int,int);
int sk_image_make_subset (int,int);
int sk_image_make_texture_image (int,int,int);
int sk_image_make_with_filter (int,int,int,int,int,int,int);
int sk_image_make_with_filter_legacy (int,int,int,int,int,int);
int sk_image_new_from_adopted_texture (int,int,int,int,int,int);
int sk_image_new_from_bitmap (int);
int sk_image_new_from_encoded (int);
int sk_image_new_from_picture (int,int,int,int);
int sk_image_new_from_texture (int,int,int,int,int,int,int,int);
int sk_image_new_raster (int,int,int);
int sk_image_new_raster_copy (int,int,int);
int sk_image_new_raster_copy_with_pixmap (int);
int sk_image_new_raster_data (int,int,int);
int sk_image_peek_pixels (int,int);
int sk_image_read_pixels (int,int,int,int,int,int,int);
int sk_image_read_pixels_into_pixmap (int,int,int,int,int);
void sk_image_ref (int);
int sk_image_ref_encoded (int);
int sk_image_scale_pixels (int,int,int,int);
void sk_image_unref (int);
void sk_imagefilter_croprect_destructor (int);
int sk_imagefilter_croprect_get_flags (int);
void sk_imagefilter_croprect_get_rect (int,int);
int sk_imagefilter_croprect_new ();
int sk_imagefilter_croprect_new_with_rect (int,int);
int sk_imagefilter_new_alpha_threshold (int,float,float,int);
int sk_imagefilter_new_arithmetic (float,float,float,float,int,int,int,int);
int sk_imagefilter_new_blur (float,float,int,int,int);
int sk_imagefilter_new_color_filter (int,int,int);
int sk_imagefilter_new_compose (int,int);
int sk_imagefilter_new_dilate (float,float,int,int);
int sk_imagefilter_new_displacement_map_effect (int,int,float,int,int,int);
int sk_imagefilter_new_distant_lit_diffuse (int,int,float,float,int,int);
int sk_imagefilter_new_distant_lit_specular (int,int,float,float,float,int,int);
int sk_imagefilter_new_drop_shadow (float,float,float,float,int,int,int);
int sk_imagefilter_new_drop_shadow_only (float,float,float,float,int,int,int);
int sk_imagefilter_new_erode (float,float,int,int);
int sk_imagefilter_new_image_source (int,int,int,int);
int sk_imagefilter_new_image_source_default (int);
int sk_imagefilter_new_magnifier (int,float,int,int);
int sk_imagefilter_new_matrix (int,int,int);
int sk_imagefilter_new_matrix_convolution (int,int,float,float,int,int,int,int,int);
int sk_imagefilter_new_merge (int,int,int);
int sk_imagefilter_new_offset (float,float,int,int);
int sk_imagefilter_new_paint (int,int);
int sk_imagefilter_new_picture (int);
int sk_imagefilter_new_picture_with_croprect (int,int);
int sk_imagefilter_new_point_lit_diffuse (int,int,float,float,int,int);
int sk_imagefilter_new_point_lit_specular (int,int,float,float,float,int,int);
int sk_imagefilter_new_spot_lit_diffuse (int,int,float,float,int,float,float,int,int);
int sk_imagefilter_new_spot_lit_specular (int,int,float,float,int,float,float,float,int,int);
int sk_imagefilter_new_tile (int,int,int);
int sk_imagefilter_new_xfermode (int,int,int,int);
void sk_imagefilter_unref (int);
int sk_jpegencoder_encode (int,int,int);
int sk_manageddrawable_new (int);
void sk_manageddrawable_set_procs (int);
void sk_manageddrawable_unref (int);
void sk_managedstream_destroy (int);
int sk_managedstream_new (int);
void sk_managedstream_set_procs (int);
void sk_managedtracememorydump_delete (int);
int sk_managedtracememorydump_new (int,int,int);
void sk_managedtracememorydump_set_procs (int);
void sk_managedwstream_destroy (int);
int sk_managedwstream_new (int);
void sk_managedwstream_set_procs (int);
int sk_mask_alloc_image (int);
int sk_mask_compute_image_size (int);
int sk_mask_compute_total_image_size (int);
void sk_mask_free_image (int);
int sk_mask_get_addr (int,int,int);
int sk_mask_get_addr_1 (int,int,int);
int sk_mask_get_addr_32 (int,int,int);
int sk_mask_get_addr_8 (int,int,int);
int sk_mask_get_addr_lcd_16 (int,int,int);
int sk_mask_is_empty (int);
int sk_maskfilter_new_blur (int,float);
int sk_maskfilter_new_blur_with_flags (int,float,int);
int sk_maskfilter_new_clip (int,int);
int sk_maskfilter_new_gamma (float);
int sk_maskfilter_new_shader (int);
int sk_maskfilter_new_table (int);
void sk_maskfilter_ref (int);
void sk_maskfilter_unref (int);
void sk_matrix_concat (int,int,int);
void sk_matrix_map_points (int,int,int,int);
float sk_matrix_map_radius (int,float);
void sk_matrix_map_rect (int,int,int);
void sk_matrix_map_vector (int,float,float,int);
void sk_matrix_map_vectors (int,int,int,int);
void sk_matrix_map_xy (int,float,float,int);
void sk_matrix_post_concat (int,int);
void sk_matrix_pre_concat (int,int);
int sk_matrix_try_invert (int,int);
void sk_matrix44_as_col_major (int,int);
void sk_matrix44_as_row_major (int,int);
void sk_matrix44_destroy (int);
double sk_matrix44_determinant (int);
int sk_matrix44_equals (int,int);
float sk_matrix44_get (int,int,int);
int sk_matrix44_get_type (int);
int sk_matrix44_invert (int,int);
void sk_matrix44_map_scalars (int,int,int);
void sk_matrix44_map2 (int,int,int,int);
int sk_matrix44_new ();
int sk_matrix44_new_concat (int,int);
int sk_matrix44_new_copy (int);
int sk_matrix44_new_identity ();
int sk_matrix44_new_matrix (int);
void sk_matrix44_post_concat (int,int);
void sk_matrix44_post_scale (int,float,float,float);
void sk_matrix44_post_translate (int,float,float,float);
void sk_matrix44_pre_concat (int,int);
void sk_matrix44_pre_scale (int,float,float,float);
void sk_matrix44_pre_translate (int,float,float,float);
int sk_matrix44_preserves_2d_axis_alignment (int,float);
void sk_matrix44_set (int,int,int,float);
void sk_matrix44_set_3x3_row_major (int,int);
void sk_matrix44_set_col_major (int,int);
void sk_matrix44_set_concat (int,int,int);
void sk_matrix44_set_identity (int);
void sk_matrix44_set_rotate_about_degrees (int,float,float,float,float);
void sk_matrix44_set_rotate_about_radians (int,float,float,float,float);
void sk_matrix44_set_rotate_about_radians_unit (int,float,float,float,float);
void sk_matrix44_set_row_major (int,int);
void sk_matrix44_set_scale (int,float,float,float);
void sk_matrix44_set_translate (int,float,float,float);
void sk_matrix44_to_matrix (int,int);
void sk_matrix44_transpose (int);
void sk_memorystream_destroy (int);
int sk_memorystream_new ();
int sk_memorystream_new_with_data (int,int,int);
int sk_memorystream_new_with_length (int);
int sk_memorystream_new_with_skdata (int);
void sk_memorystream_set_memory (int,int,int,int);
void sk_nodraw_canvas_destroy (int);
int sk_nodraw_canvas_new (int,int);
int sk_nvrefcnt_get_ref_count (int);
void sk_nvrefcnt_safe_ref (int);
void sk_nvrefcnt_safe_unref (int);
int sk_nvrefcnt_unique (int);
void sk_nway_canvas_add_canvas (int,int);
void sk_nway_canvas_destroy (int);
int sk_nway_canvas_new (int,int);
void sk_nway_canvas_remove_all (int);
void sk_nway_canvas_remove_canvas (int,int);
void sk_opbuilder_add (int,int,int);
void sk_opbuilder_destroy (int);
int sk_opbuilder_new ();
int sk_opbuilder_resolve (int,int);
void sk_overdraw_canvas_destroy (int);
int sk_overdraw_canvas_new (int);
int sk_paint_clone (int);
void sk_paint_delete (int);
int sk_paint_get_blendmode (int);
int sk_paint_get_color (int);
void sk_paint_get_color4f (int,int);
int sk_paint_get_colorfilter (int);
int sk_paint_get_fill_path (int,int,int,int,float);
int sk_paint_get_filter_quality (int);
int sk_paint_get_imagefilter (int);
int sk_paint_get_maskfilter (int);
int sk_paint_get_path_effect (int);
int sk_paint_get_shader (int);
int sk_paint_get_stroke_cap (int);
int sk_paint_get_stroke_join (int);
float sk_paint_get_stroke_miter (int);
float sk_paint_get_stroke_width (int);
int sk_paint_get_style (int);
int sk_paint_is_antialias (int);
int sk_paint_is_dither (int);
int sk_paint_new ();
void sk_paint_reset (int);
void sk_paint_set_antialias (int,int);
void sk_paint_set_blendmode (int,int);
void sk_paint_set_color (int,int);
void sk_paint_set_color4f (int,int,int);
void sk_paint_set_colorfilter (int,int);
void sk_paint_set_dither (int,int);
void sk_paint_set_filter_quality (int,int);
void sk_paint_set_imagefilter (int,int);
void sk_paint_set_maskfilter (int,int);
void sk_paint_set_path_effect (int,int);
void sk_paint_set_shader (int,int);
void sk_paint_set_stroke_cap (int,int);
void sk_paint_set_stroke_join (int,int);
void sk_paint_set_stroke_miter (int,float);
void sk_paint_set_stroke_width (int,float);
void sk_paint_set_style (int,int);
void sk_path_add_arc (int,int,float,float);
void sk_path_add_circle (int,float,float,float,int);
void sk_path_add_oval (int,int,int);
void sk_path_add_path (int,int,int);
void sk_path_add_path_matrix (int,int,int,int);
void sk_path_add_path_offset (int,int,float,float,int);
void sk_path_add_path_reverse (int,int);
void sk_path_add_poly (int,int,int,int);
void sk_path_add_rect (int,int,int);
void sk_path_add_rect_start (int,int,int,int);
void sk_path_add_rounded_rect (int,int,float,float,int);
void sk_path_add_rrect (int,int,int);
void sk_path_add_rrect_start (int,int,int,int);
void sk_path_arc_to (int,float,float,float,int,int,float,float);
void sk_path_arc_to_with_oval (int,int,float,float,int);
void sk_path_arc_to_with_points (int,float,float,float,float,float);
int sk_path_clone (int);
void sk_path_close (int);
void sk_path_compute_tight_bounds (int,int);
void sk_path_conic_to (int,float,float,float,float,float);
int sk_path_contains (int,float,float);
int sk_path_convert_conic_to_quads (int,int,int,float,int,int);
int sk_path_count_points (int);
int sk_path_count_verbs (int);
int sk_path_create_iter (int,int);
int sk_path_create_rawiter (int);
void sk_path_cubic_to (int,float,float,float,float,float,float);
void sk_path_delete (int);
int sk_path_effect_create_1d_path (int,float,float,int);
int sk_path_effect_create_2d_line (float,int);
int sk_path_effect_create_2d_path (int,int);
int sk_path_effect_create_compose (int,int);
int sk_path_effect_create_corner (float);
int sk_path_effect_create_dash (int,int,float);
int sk_path_effect_create_discrete (float,float,int);
int sk_path_effect_create_sum (int,int);
int sk_path_effect_create_trim (float,float,int);
void sk_path_effect_unref (int);
void sk_path_get_bounds (int,int);
int sk_path_get_filltype (int);
int sk_path_get_last_point (int,int);
void sk_path_get_point (int,int,int);
int sk_path_get_points (int,int,int);
int sk_path_get_segment_masks (int);
int sk_path_is_convex (int);
int sk_path_is_line (int,int);
int sk_path_is_oval (int,int);
int sk_path_is_rect (int,int,int,int);
int sk_path_is_rrect (int,int);
float sk_path_iter_conic_weight (int);
void sk_path_iter_destroy (int);
int sk_path_iter_is_close_line (int);
int sk_path_iter_is_closed_contour (int);
int sk_path_iter_next (int,int);
void sk_path_line_to (int,float,float);
void sk_path_move_to (int,float,float);
int sk_path_new ();
int sk_path_parse_svg_string (int,int);
void sk_path_quad_to (int,float,float,float,float);
void sk_path_rarc_to (int,float,float,float,int,int,float,float);
float sk_path_rawiter_conic_weight (int);
void sk_path_rawiter_destroy (int);
int sk_path_rawiter_next (int,int);
int sk_path_rawiter_peek (int);
void sk_path_rconic_to (int,float,float,float,float,float);
void sk_path_rcubic_to (int,float,float,float,float,float,float);
void sk_path_reset (int);
void sk_path_rewind (int);
void sk_path_rline_to (int,float,float);
void sk_path_rmove_to (int,float,float);
void sk_path_rquad_to (int,float,float,float,float);
void sk_path_set_filltype (int,int);
void sk_path_to_svg_string (int,int);
void sk_path_transform (int,int);
void sk_path_transform_to_dest (int,int,int);
void sk_pathmeasure_destroy (int);
float sk_pathmeasure_get_length (int);
int sk_pathmeasure_get_matrix (int,float,int,int);
int sk_pathmeasure_get_pos_tan (int,float,int,int);
int sk_pathmeasure_get_segment (int,float,float,int,int);
int sk_pathmeasure_is_closed (int);
int sk_pathmeasure_new ();
int sk_pathmeasure_new_with_path (int,int,float);
int sk_pathmeasure_next_contour (int);
void sk_pathmeasure_set_path (int,int,int);
int sk_pathop_as_winding (int,int);
int sk_pathop_op (int,int,int,int);
int sk_pathop_simplify (int,int);
int sk_pathop_tight_bounds (int,int);
int sk_picture_deserialize_from_data (int);
int sk_picture_deserialize_from_memory (int,int);
int sk_picture_deserialize_from_stream (int);
void sk_picture_get_cull_rect (int,int);
int sk_picture_get_recording_canvas (int);
int sk_picture_get_unique_id (int);
int sk_picture_make_shader (int,int,int,int,int);
int sk_picture_recorder_begin_recording (int,int);
void sk_picture_recorder_delete (int);
int sk_picture_recorder_end_recording (int);
int sk_picture_recorder_end_recording_as_drawable (int);
int sk_picture_recorder_new ();
void sk_picture_ref (int);
int sk_picture_serialize_to_data (int);
void sk_picture_serialize_to_stream (int,int);
void sk_picture_unref (int);
void sk_pixmap_destructor (int);
int sk_pixmap_encode_image (int,int,int,int);
int sk_pixmap_erase_color (int,int,int);
int sk_pixmap_erase_color4f (int,int,int,int);
int sk_pixmap_extract_subset (int,int,int);
void sk_pixmap_get_info (int,int);
int sk_pixmap_get_pixel_color (int,int,int);
int sk_pixmap_get_pixels (int);
int sk_pixmap_get_pixels_with_xy (int,int,int);
int sk_pixmap_get_row_bytes (int);
int sk_pixmap_get_writable_addr (int);
int sk_pixmap_new ();
int sk_pixmap_new_with_params (int,int,int);
int sk_pixmap_read_pixels (int,int,int,int,int,int);
void sk_pixmap_reset (int);
void sk_pixmap_reset_with_params (int,int,int,int);
int sk_pixmap_scale_pixels (int,int,int);
int sk_pngencoder_encode (int,int,int);
int sk_refcnt_get_ref_count (int);
void sk_refcnt_safe_ref (int);
void sk_refcnt_safe_unref (int);
int sk_refcnt_unique (int);
void sk_region_cliperator_delete (int);
int sk_region_cliperator_done (int);
int sk_region_cliperator_new (int,int);
void sk_region_cliperator_next (int);
void sk_region_cliperator_rect (int,int);
int sk_region_contains (int,int);
int sk_region_contains_point (int,int,int);
int sk_region_contains_rect (int,int);
void sk_region_delete (int);
int sk_region_get_boundary_path (int,int);
void sk_region_get_bounds (int,int);
int sk_region_intersects (int,int);
int sk_region_intersects_rect (int,int);
int sk_region_is_complex (int);
int sk_region_is_empty (int);
int sk_region_is_rect (int);
void sk_region_iterator_delete (int);
int sk_region_iterator_done (int);
int sk_region_iterator_new (int);
void sk_region_iterator_next (int);
void sk_region_iterator_rect (int,int);
int sk_region_iterator_rewind (int);
int sk_region_new ();
int sk_region_op (int,int,int);
int sk_region_op_rect (int,int,int);
int sk_region_quick_contains (int,int);
int sk_region_quick_reject (int,int);
int sk_region_quick_reject_rect (int,int);
int sk_region_set_empty (int);
int sk_region_set_path (int,int,int);
int sk_region_set_rect (int,int);
int sk_region_set_rects (int,int,int);
int sk_region_set_region (int,int);
void sk_region_spanerator_delete (int);
int sk_region_spanerator_new (int,int,int,int);
int sk_region_spanerator_next (int,int,int);
void sk_region_translate (int,int,int);
int sk_rrect_contains (int,int);
void sk_rrect_delete (int);
float sk_rrect_get_height (int);
void sk_rrect_get_radii (int,int,int);
void sk_rrect_get_rect (int,int);
int sk_rrect_get_type (int);
float sk_rrect_get_width (int);
void sk_rrect_inset (int,float,float);
int sk_rrect_is_valid (int);
int sk_rrect_new ();
int sk_rrect_new_copy (int);
void sk_rrect_offset (int,float,float);
void sk_rrect_outset (int,float,float);
void sk_rrect_set_empty (int);
void sk_rrect_set_nine_patch (int,int,float,float,float,float);
void sk_rrect_set_oval (int,int);
void sk_rrect_set_rect (int,int);
void sk_rrect_set_rect_radii (int,int,int);
void sk_rrect_set_rect_xy (int,int,float,float);
int sk_rrect_transform (int,int,int);
void sk_runtimeeffect_get_child_name (int,int,int);
int sk_runtimeeffect_get_children_count (int);
int sk_runtimeeffect_get_uniform_from_index (int,int);
int sk_runtimeeffect_get_uniform_from_name (int,int,int);
void sk_runtimeeffect_get_uniform_name (int,int,int);
int sk_runtimeeffect_get_uniform_size (int);
int sk_runtimeeffect_get_uniforms_count (int);
int sk_runtimeeffect_make (int,int);
int sk_runtimeeffect_make_color_filter (int,int,int,int);
int sk_runtimeeffect_make_shader (int,int,int,int,int,int);
int sk_runtimeeffect_uniform_get_offset (int);
int sk_runtimeeffect_uniform_get_size_in_bytes (int);
void sk_runtimeeffect_unref (int);
int sk_shader_new_blend (int,int,int);
int sk_shader_new_color (int);
int sk_shader_new_color4f (int,int);
int sk_shader_new_empty ();
int sk_shader_new_lerp (float,int,int);
int sk_shader_new_linear_gradient (int,int,int,int,int,int);
int sk_shader_new_linear_gradient_color4f (int,int,int,int,int,int,int);
int sk_shader_new_perlin_noise_fractal_noise (float,float,int,float,int);
int sk_shader_new_perlin_noise_improved_noise (float,float,int,float);
int sk_shader_new_perlin_noise_turbulence (float,float,int,float,int);
int sk_shader_new_radial_gradient (int,float,int,int,int,int,int);
int sk_shader_new_radial_gradient_color4f (int,float,int,int,int,int,int,int);
int sk_shader_new_sweep_gradient (int,int,int,int,int,float,float,int);
int sk_shader_new_sweep_gradient_color4f (int,int,int,int,int,int,float,float,int);
int sk_shader_new_two_point_conical_gradient (int,float,int,float,int,int,int,int,int);
int sk_shader_new_two_point_conical_gradient_color4f (int,float,int,float,int,int,int,int,int,int);
void sk_shader_ref (int);
void sk_shader_unref (int);
int sk_shader_with_color_filter (int,int);
int sk_shader_with_local_matrix (int,int);
void sk_stream_asset_destroy (int);
void sk_stream_destroy (int);
int sk_stream_duplicate (int);
int sk_stream_fork (int);
int sk_stream_get_length (int);
int sk_stream_get_memory_base (int);
int sk_stream_get_position (int);
int sk_stream_has_length (int);
int sk_stream_has_position (int);
int sk_stream_is_at_end (int);
int sk_stream_move (int,int);
int sk_stream_peek (int,int,int);
int sk_stream_read (int,int,int);
int sk_stream_read_bool (int,int);
int sk_stream_read_s16 (int,int);
int sk_stream_read_s32 (int,int);
int sk_stream_read_s8 (int,int);
int sk_stream_read_u16 (int,int);
int sk_stream_read_u32 (int,int);
int sk_stream_read_u8 (int,int);
int sk_stream_rewind (int);
int sk_stream_seek (int,int);
int sk_stream_skip (int,int);
void sk_string_destructor (int);
int sk_string_get_c_str (int);
int sk_string_get_size (int);
int sk_string_new_empty ();
int sk_string_new_with_copy (int,int);
void sk_surface_draw (int,int,float,float,int);
void sk_surface_flush (int);
void sk_surface_flush_and_submit (int,int);
int sk_surface_get_canvas (int);
int sk_surface_get_props (int);
int sk_surface_get_recording_context (int);
int sk_surface_new_backend_render_target (int,int,int,int,int,int);
int sk_surface_new_backend_texture (int,int,int,int,int,int,int);
int sk_surface_new_image_snapshot (int);
int sk_surface_new_image_snapshot_with_crop (int,int);
int sk_surface_new_metal_layer (int,int,int,int,int,int,int,int);
int sk_surface_new_metal_view (int,int,int,int,int,int,int);
int sk_surface_new_null (int,int);
int sk_surface_new_raster (int,int,int);
int sk_surface_new_raster_direct (int,int,int,int,int,int);
int sk_surface_new_render_target (int,int,int,int,int,int,int);
int sk_surface_peek_pixels (int,int);
int sk_surface_read_pixels (int,int,int,int,int,int);
void sk_surface_unref (int);
void sk_surfaceprops_delete (int);
int sk_surfaceprops_get_flags (int);
int sk_surfaceprops_get_pixel_geometry (int);
int sk_surfaceprops_new (int,int);
int sk_svgcanvas_create_with_stream (int,int);
int sk_svgcanvas_create_with_writer (int,int);
void sk_swizzle_swap_rb (int,int,int);
void sk_text_utils_get_path (int,int,int,float,float,int,int);
void sk_text_utils_get_pos_path (int,int,int,int,int,int);
void sk_textblob_builder_alloc_run (int,int,int,float,float,int,int);
void sk_textblob_builder_alloc_run_pos (int,int,int,int,int);
void sk_textblob_builder_alloc_run_pos_h (int,int,int,float,int,int);
void sk_textblob_builder_alloc_run_rsxform (int,int,int,int);
void sk_textblob_builder_alloc_run_text (int,int,int,float,float,int,int,int);
void sk_textblob_builder_alloc_run_text_pos (int,int,int,int,int,int);
void sk_textblob_builder_alloc_run_text_pos_h (int,int,int,float,int,int,int);
void sk_textblob_builder_delete (int);
int sk_textblob_builder_make (int);
int sk_textblob_builder_new ();
void sk_textblob_get_bounds (int,int);
int sk_textblob_get_intercepts (int,int,int,int);
int sk_textblob_get_unique_id (int);
void sk_textblob_ref (int);
void sk_textblob_unref (int);
int sk_typeface_copy_table_data (int,int);
int sk_typeface_count_glyphs (int);
int sk_typeface_count_tables (int);
int sk_typeface_create_default ();
int sk_typeface_create_from_data (int,int);
int sk_typeface_create_from_file (int,int);
int sk_typeface_create_from_name (int,int);
int sk_typeface_create_from_stream (int,int);
int sk_typeface_get_family_name (int);
int sk_typeface_get_font_slant (int);
int sk_typeface_get_font_weight (int);
int sk_typeface_get_font_width (int);
int sk_typeface_get_fontstyle (int);
int sk_typeface_get_kerning_pair_adjustments (int,int,int,int);
int sk_typeface_get_table_data (int,int,int,int,int);
int sk_typeface_get_table_size (int,int);
int sk_typeface_get_table_tags (int,int);
int sk_typeface_get_units_per_em (int);
int sk_typeface_is_fixed_pitch (int);
int sk_typeface_open_stream (int,int);
int sk_typeface_ref_default ();
int sk_typeface_unichar_to_glyph (int,int);
void sk_typeface_unichars_to_glyphs (int,int,int,int);
void sk_typeface_unref (int);
int sk_version_get_increment ();
int sk_version_get_milestone ();
int sk_version_get_string ();
int sk_vertices_make_copy (int,int,int,int,int,int,int);
void sk_vertices_ref (int);
void sk_vertices_unref (int);
int sk_webpencoder_encode (int,int,int);
int sk_wstream_bytes_written (int);
void sk_wstream_flush (int);
int sk_wstream_get_size_of_packed_uint (int);
int sk_wstream_newline (int);
int sk_wstream_write (int,int,int);
int sk_wstream_write_16 (int,int);
int sk_wstream_write_32 (int,int);
int sk_wstream_write_8 (int,int);
int sk_wstream_write_bigdec_as_text (int,int64_t,int);
int sk_wstream_write_bool (int,int);
int sk_wstream_write_dec_as_text (int,int);
int sk_wstream_write_hex_as_text (int,int,int);
int sk_wstream_write_packed_uint (int,int);
int sk_wstream_write_scalar (int,float);
int sk_wstream_write_scalar_as_text (int,float);
int sk_wstream_write_stream (int,int,int);
int sk_wstream_write_text (int,int);
void sk_xmlstreamwriter_delete (int);
int sk_xmlstreamwriter_new (int);
int SystemNative_Access (int,int);
int SystemNative_AlignedAlloc (int,int);
void SystemNative_AlignedFree (int);
int SystemNative_AlignedRealloc (int,int,int);
int SystemNative_Calloc (int,int);
int SystemNative_CanGetHiddenFlag ();
int SystemNative_ChDir (int);
int SystemNative_ChMod (int,int);
int SystemNative_Close (int);
int SystemNative_CloseDir (int);
int SystemNative_ConvertErrorPalToPlatform (int);
int SystemNative_ConvertErrorPlatformToPal (int);
int SystemNative_CopyFile (int,int,int64_t);
int SystemNative_Dup (int);
int SystemNative_FAllocate (int,int64_t,int64_t);
int SystemNative_FChflags (int,int);
int SystemNative_FChMod (int,int);
int SystemNative_FcntlSetFD (int,int);
int SystemNative_FLock (int,int);
void SystemNative_Free (int);
void SystemNative_FreeEnviron (int);
int SystemNative_FStat (int,int);
int SystemNative_FSync (int);
int SystemNative_FTruncate (int,int64_t);
int SystemNative_FUTimens (int,int);
int SystemNative_GetAddressFamily (int,int,int);
double SystemNative_GetCpuUtilization (int);
int SystemNative_GetCryptographicallySecureRandomBytes (int,int);
int SystemNative_GetCwd (int,int);
int SystemNative_GetDefaultSearchOrderPseudoHandle ();
int SystemNative_GetEnv (int);
int SystemNative_GetEnviron ();
int SystemNative_GetErrNo ();
int SystemNative_GetFileSystemType (int);
int SystemNative_GetIPSocketAddressSizes (int,int);
int SystemNative_GetIPv4Address (int,int,int);
int SystemNative_GetIPv6Address (int,int,int,int,int);
void SystemNative_GetNonCryptographicallySecureRandomBytes (int,int);
int SystemNative_GetPort (int,int,int);
int SystemNative_GetReadDirRBufferSize ();
int64_t SystemNative_GetSystemTimeAsTicks ();
uint64_t SystemNative_GetTimestamp ();
int SystemNative_LChflags (int,int);
int SystemNative_LChflagsCanSetHiddenFlag ();
int SystemNative_Link (int,int);
int SystemNative_LockFileRegion (int,int64_t,int64_t,int);
void SystemNative_Log (int,int);
void SystemNative_LogError (int,int);
void SystemNative_LowLevelMonitor_Acquire (int);
int SystemNative_LowLevelMonitor_Create ();
void SystemNative_LowLevelMonitor_Destroy (int);
void SystemNative_LowLevelMonitor_Release (int);
void SystemNative_LowLevelMonitor_Signal_Release (int);
int SystemNative_LowLevelMonitor_TimedWait (int,int);
void SystemNative_LowLevelMonitor_Wait (int);
int64_t SystemNative_LSeek (int,int64_t,int);
int SystemNative_LStat (int,int);
int SystemNative_MAdvise (int,uint64_t,int);
int SystemNative_Malloc (int);
int SystemNative_MkDir (int,int);
int SystemNative_MkdTemp (int);
int SystemNative_MksTemps (int,int);
int SystemNative_MMap (int,uint64_t,int,int,int,int64_t);
int SystemNative_MSync (int,uint64_t,int);
int SystemNative_MUnmap (int,uint64_t);
int SystemNative_Open (int,int,int);
int SystemNative_OpenDir (int);
int SystemNative_PosixFAdvise (int,int64_t,int64_t,int);
int SystemNative_PRead (int,int,int,int64_t);
int64_t SystemNative_PReadV (int,int,int,int64_t);
int SystemNative_PWrite (int,int,int,int64_t);
int64_t SystemNative_PWriteV (int,int,int,int64_t);
int SystemNative_Read (int,int,int);
int SystemNative_ReadDirR (int,int,int,int);
int SystemNative_ReadLink (int,int,int);
int SystemNative_Realloc (int,int);
int SystemNative_Rename (int,int);
int SystemNative_RmDir (int);
int SystemNative_SetAddressFamily (int,int,int);
void SystemNative_SetErrNo (int);
int SystemNative_SetIPv4Address (int,int,int);
int SystemNative_SetIPv6Address (int,int,int,int,int);
int SystemNative_SetPort (int,int,int);
int SystemNative_ShmOpen (int,int,int);
int SystemNative_ShmUnlink (int);
int SystemNative_Stat (int,int);
int SystemNative_StrErrorR (int,int,int);
int SystemNative_SymLink (int,int);
int64_t SystemNative_SysConf (int);
void SystemNative_SysLog (int,int,int);
int SystemNative_Unlink (int);
int SystemNative_UTimensat (int,int);
int SystemNative_Write (int,int,int);
static PinvokeImport libSkiaSharp_imports [] = {
{"gr_backendrendertarget_delete", gr_backendrendertarget_delete}, // SkiaSharp
{"gr_backendrendertarget_get_backend", gr_backendrendertarget_get_backend}, // SkiaSharp
{"gr_backendrendertarget_get_gl_framebufferinfo", gr_backendrendertarget_get_gl_framebufferinfo}, // SkiaSharp
{"gr_backendrendertarget_get_height", gr_backendrendertarget_get_height}, // SkiaSharp
{"gr_backendrendertarget_get_samples", gr_backendrendertarget_get_samples}, // SkiaSharp
{"gr_backendrendertarget_get_stencils", gr_backendrendertarget_get_stencils}, // SkiaSharp
{"gr_backendrendertarget_get_width", gr_backendrendertarget_get_width}, // SkiaSharp
{"gr_backendrendertarget_is_valid", gr_backendrendertarget_is_valid}, // SkiaSharp
{"gr_backendrendertarget_new_gl", gr_backendrendertarget_new_gl}, // SkiaSharp
{"gr_backendrendertarget_new_metal", gr_backendrendertarget_new_metal}, // SkiaSharp
{"gr_backendrendertarget_new_vulkan", gr_backendrendertarget_new_vulkan}, // SkiaSharp
{"gr_backendtexture_delete", gr_backendtexture_delete}, // SkiaSharp
{"gr_backendtexture_get_backend", gr_backendtexture_get_backend}, // SkiaSharp
{"gr_backendtexture_get_gl_textureinfo", gr_backendtexture_get_gl_textureinfo}, // SkiaSharp
{"gr_backendtexture_get_height", gr_backendtexture_get_height}, // SkiaSharp
{"gr_backendtexture_get_width", gr_backendtexture_get_width}, // SkiaSharp
{"gr_backendtexture_has_mipmaps", gr_backendtexture_has_mipmaps}, // SkiaSharp
{"gr_backendtexture_is_valid", gr_backendtexture_is_valid}, // SkiaSharp
{"gr_backendtexture_new_gl", gr_backendtexture_new_gl}, // SkiaSharp
{"gr_backendtexture_new_metal", gr_backendtexture_new_metal}, // SkiaSharp
{"gr_backendtexture_new_vulkan", gr_backendtexture_new_vulkan}, // SkiaSharp
{"gr_direct_context_abandon_context", gr_direct_context_abandon_context}, // SkiaSharp
{"gr_direct_context_dump_memory_statistics", gr_direct_context_dump_memory_statistics}, // SkiaSharp
{"gr_direct_context_flush", gr_direct_context_flush}, // SkiaSharp
{"gr_direct_context_flush_and_submit", gr_direct_context_flush_and_submit}, // SkiaSharp
{"gr_direct_context_free_gpu_resources", gr_direct_context_free_gpu_resources}, // SkiaSharp
{"gr_direct_context_get_resource_cache_limit", gr_direct_context_get_resource_cache_limit}, // SkiaSharp
{"gr_direct_context_get_resource_cache_usage", gr_direct_context_get_resource_cache_usage}, // SkiaSharp
{"gr_direct_context_is_abandoned", gr_direct_context_is_abandoned}, // SkiaSharp
{"gr_direct_context_make_gl", gr_direct_context_make_gl}, // SkiaSharp
{"gr_direct_context_make_gl_with_options", gr_direct_context_make_gl_with_options}, // SkiaSharp
{"gr_direct_context_make_metal", gr_direct_context_make_metal}, // SkiaSharp
{"gr_direct_context_make_metal_with_options", gr_direct_context_make_metal_with_options}, // SkiaSharp
{"gr_direct_context_make_vulkan", gr_direct_context_make_vulkan}, // SkiaSharp
{"gr_direct_context_make_vulkan_with_options", gr_direct_context_make_vulkan_with_options}, // SkiaSharp
{"gr_direct_context_perform_deferred_cleanup", gr_direct_context_perform_deferred_cleanup}, // SkiaSharp
{"gr_direct_context_purge_unlocked_resources", gr_direct_context_purge_unlocked_resources}, // SkiaSharp
{"gr_direct_context_purge_unlocked_resources_bytes", gr_direct_context_purge_unlocked_resources_bytes}, // SkiaSharp
{"gr_direct_context_release_resources_and_abandon_context", gr_direct_context_release_resources_and_abandon_context}, // SkiaSharp
{"gr_direct_context_reset_context", gr_direct_context_reset_context}, // SkiaSharp
{"gr_direct_context_set_resource_cache_limit", gr_direct_context_set_resource_cache_limit}, // SkiaSharp
{"gr_direct_context_submit", gr_direct_context_submit}, // SkiaSharp
{"gr_glinterface_assemble_gl_interface", gr_glinterface_assemble_gl_interface}, // SkiaSharp
{"gr_glinterface_assemble_gles_interface", gr_glinterface_assemble_gles_interface}, // SkiaSharp
{"gr_glinterface_assemble_interface", gr_glinterface_assemble_interface}, // SkiaSharp
{"gr_glinterface_assemble_webgl_interface", gr_glinterface_assemble_webgl_interface}, // SkiaSharp
{"gr_glinterface_create_native_interface", gr_glinterface_create_native_interface}, // SkiaSharp
{"gr_glinterface_has_extension", gr_glinterface_has_extension}, // SkiaSharp
{"gr_glinterface_unref", gr_glinterface_unref}, // SkiaSharp
{"gr_glinterface_validate", gr_glinterface_validate}, // SkiaSharp
{"gr_recording_context_get_backend", gr_recording_context_get_backend}, // SkiaSharp
{"gr_recording_context_get_max_surface_sample_count_for_color_type", gr_recording_context_get_max_surface_sample_count_for_color_type}, // SkiaSharp
{"gr_recording_context_unref", gr_recording_context_unref}, // SkiaSharp
{"gr_vk_extensions_delete", gr_vk_extensions_delete}, // SkiaSharp
{"gr_vk_extensions_has_extension", gr_vk_extensions_has_extension}, // SkiaSharp
{"gr_vk_extensions_init", gr_vk_extensions_init}, // SkiaSharp
{"gr_vk_extensions_new", gr_vk_extensions_new}, // SkiaSharp
{"sk_3dview_apply_to_canvas", sk_3dview_apply_to_canvas}, // SkiaSharp
{"sk_3dview_destroy", sk_3dview_destroy}, // SkiaSharp
{"sk_3dview_dot_with_normal", sk_3dview_dot_with_normal}, // SkiaSharp
{"sk_3dview_get_matrix", sk_3dview_get_matrix}, // SkiaSharp
{"sk_3dview_new", sk_3dview_new}, // SkiaSharp
{"sk_3dview_restore", sk_3dview_restore}, // SkiaSharp
{"sk_3dview_rotate_x_degrees", sk_3dview_rotate_x_degrees}, // SkiaSharp
{"sk_3dview_rotate_x_radians", sk_3dview_rotate_x_radians}, // SkiaSharp
{"sk_3dview_rotate_y_degrees", sk_3dview_rotate_y_degrees}, // SkiaSharp
{"sk_3dview_rotate_y_radians", sk_3dview_rotate_y_radians}, // SkiaSharp
{"sk_3dview_rotate_z_degrees", sk_3dview_rotate_z_degrees}, // SkiaSharp
{"sk_3dview_rotate_z_radians", sk_3dview_rotate_z_radians}, // SkiaSharp
{"sk_3dview_save", sk_3dview_save}, // SkiaSharp
{"sk_3dview_translate", sk_3dview_translate}, // SkiaSharp
{"sk_bitmap_destructor", sk_bitmap_destructor}, // SkiaSharp
{"sk_bitmap_erase", sk_bitmap_erase}, // SkiaSharp
{"sk_bitmap_erase_rect", sk_bitmap_erase_rect}, // SkiaSharp
{"sk_bitmap_extract_alpha", sk_bitmap_extract_alpha}, // SkiaSharp
{"sk_bitmap_extract_subset", sk_bitmap_extract_subset}, // SkiaSharp
{"sk_bitmap_get_addr", sk_bitmap_get_addr}, // SkiaSharp
{"sk_bitmap_get_addr_16", sk_bitmap_get_addr_16}, // SkiaSharp
{"sk_bitmap_get_addr_32", sk_bitmap_get_addr_32}, // SkiaSharp
{"sk_bitmap_get_addr_8", sk_bitmap_get_addr_8}, // SkiaSharp
{"sk_bitmap_get_byte_count", sk_bitmap_get_byte_count}, // SkiaSharp
{"sk_bitmap_get_info", sk_bitmap_get_info}, // SkiaSharp
{"sk_bitmap_get_pixel_color", sk_bitmap_get_pixel_color}, // SkiaSharp
{"sk_bitmap_get_pixel_colors", sk_bitmap_get_pixel_colors}, // SkiaSharp
{"sk_bitmap_get_pixels", sk_bitmap_get_pixels}, // SkiaSharp
{"sk_bitmap_get_row_bytes", sk_bitmap_get_row_bytes}, // SkiaSharp
{"sk_bitmap_install_mask_pixels", sk_bitmap_install_mask_pixels}, // SkiaSharp
{"sk_bitmap_install_pixels", sk_bitmap_install_pixels}, // SkiaSharp
{"sk_bitmap_install_pixels_with_pixmap", sk_bitmap_install_pixels_with_pixmap}, // SkiaSharp
{"sk_bitmap_is_immutable", sk_bitmap_is_immutable}, // SkiaSharp
{"sk_bitmap_is_null", sk_bitmap_is_null}, // SkiaSharp
{"sk_bitmap_make_shader", sk_bitmap_make_shader}, // SkiaSharp
{"sk_bitmap_new", sk_bitmap_new}, // SkiaSharp
{"sk_bitmap_notify_pixels_changed", sk_bitmap_notify_pixels_changed}, // SkiaSharp
{"sk_bitmap_peek_pixels", sk_bitmap_peek_pixels}, // SkiaSharp
{"sk_bitmap_ready_to_draw", sk_bitmap_ready_to_draw}, // SkiaSharp
{"sk_bitmap_reset", sk_bitmap_reset}, // SkiaSharp
{"sk_bitmap_set_immutable", sk_bitmap_set_immutable}, // SkiaSharp
{"sk_bitmap_set_pixels", sk_bitmap_set_pixels}, // SkiaSharp
{"sk_bitmap_swap", sk_bitmap_swap}, // SkiaSharp
{"sk_bitmap_try_alloc_pixels", sk_bitmap_try_alloc_pixels}, // SkiaSharp
{"sk_bitmap_try_alloc_pixels_with_flags", sk_bitmap_try_alloc_pixels_with_flags}, // SkiaSharp
{"sk_canvas_clear", sk_canvas_clear}, // SkiaSharp
{"sk_canvas_clear_color4f", sk_canvas_clear_color4f}, // SkiaSharp
{"sk_canvas_clip_path_with_operation", sk_canvas_clip_path_with_operation}, // SkiaSharp
{"sk_canvas_clip_rect_with_operation", sk_canvas_clip_rect_with_operation}, // SkiaSharp
{"sk_canvas_clip_region", sk_canvas_clip_region}, // SkiaSharp
{"sk_canvas_clip_rrect_with_operation", sk_canvas_clip_rrect_with_operation}, // SkiaSharp
{"sk_canvas_concat", sk_canvas_concat}, // SkiaSharp
{"sk_canvas_destroy", sk_canvas_destroy}, // SkiaSharp
{"sk_canvas_discard", sk_canvas_discard}, // SkiaSharp
{"sk_canvas_draw_annotation", sk_canvas_draw_annotation}, // SkiaSharp
{"sk_canvas_draw_arc", sk_canvas_draw_arc}, // SkiaSharp
{"sk_canvas_draw_atlas", sk_canvas_draw_atlas}, // SkiaSharp
{"sk_canvas_draw_circle", sk_canvas_draw_circle}, // SkiaSharp
{"sk_canvas_draw_color", sk_canvas_draw_color}, // SkiaSharp
{"sk_canvas_draw_color4f", sk_canvas_draw_color4f}, // SkiaSharp
{"sk_canvas_draw_drawable", sk_canvas_draw_drawable}, // SkiaSharp
{"sk_canvas_draw_drrect", sk_canvas_draw_drrect}, // SkiaSharp
{"sk_canvas_draw_image", sk_canvas_draw_image}, // SkiaSharp
{"sk_canvas_draw_image_lattice", sk_canvas_draw_image_lattice}, // SkiaSharp
{"sk_canvas_draw_image_nine", sk_canvas_draw_image_nine}, // SkiaSharp
{"sk_canvas_draw_image_rect", sk_canvas_draw_image_rect}, // SkiaSharp
{"sk_canvas_draw_line", sk_canvas_draw_line}, // SkiaSharp
{"sk_canvas_draw_link_destination_annotation", sk_canvas_draw_link_destination_annotation}, // SkiaSharp
{"sk_canvas_draw_named_destination_annotation", sk_canvas_draw_named_destination_annotation}, // SkiaSharp
{"sk_canvas_draw_oval", sk_canvas_draw_oval}, // SkiaSharp
{"sk_canvas_draw_paint", sk_canvas_draw_paint}, // SkiaSharp
{"sk_canvas_draw_patch", sk_canvas_draw_patch}, // SkiaSharp
{"sk_canvas_draw_path", sk_canvas_draw_path}, // SkiaSharp
{"sk_canvas_draw_picture", sk_canvas_draw_picture}, // SkiaSharp
{"sk_canvas_draw_point", sk_canvas_draw_point}, // SkiaSharp
{"sk_canvas_draw_points", sk_canvas_draw_points}, // SkiaSharp
{"sk_canvas_draw_rect", sk_canvas_draw_rect}, // SkiaSharp
{"sk_canvas_draw_region", sk_canvas_draw_region}, // SkiaSharp
{"sk_canvas_draw_round_rect", sk_canvas_draw_round_rect}, // SkiaSharp
{"sk_canvas_draw_rrect", sk_canvas_draw_rrect}, // SkiaSharp
{"sk_canvas_draw_simple_text", sk_canvas_draw_simple_text}, // SkiaSharp
{"sk_canvas_draw_text_blob", sk_canvas_draw_text_blob}, // SkiaSharp
{"sk_canvas_draw_url_annotation", sk_canvas_draw_url_annotation}, // SkiaSharp
{"sk_canvas_draw_vertices", sk_canvas_draw_vertices}, // SkiaSharp
{"sk_canvas_flush", sk_canvas_flush}, // SkiaSharp
{"sk_canvas_get_device_clip_bounds", sk_canvas_get_device_clip_bounds}, // SkiaSharp
{"sk_canvas_get_local_clip_bounds", sk_canvas_get_local_clip_bounds}, // SkiaSharp
{"sk_canvas_get_save_count", sk_canvas_get_save_count}, // SkiaSharp
{"sk_canvas_get_total_matrix", sk_canvas_get_total_matrix}, // SkiaSharp
{"sk_canvas_is_clip_empty", sk_canvas_is_clip_empty}, // SkiaSharp
{"sk_canvas_is_clip_rect", sk_canvas_is_clip_rect}, // SkiaSharp
{"sk_canvas_new_from_bitmap", sk_canvas_new_from_bitmap}, // SkiaSharp
{"sk_canvas_quick_reject", sk_canvas_quick_reject}, // SkiaSharp
{"sk_canvas_reset_matrix", sk_canvas_reset_matrix}, // SkiaSharp
{"sk_canvas_restore", sk_canvas_restore}, // SkiaSharp
{"sk_canvas_restore_to_count", sk_canvas_restore_to_count}, // SkiaSharp
{"sk_canvas_rotate_degrees", sk_canvas_rotate_degrees}, // SkiaSharp
{"sk_canvas_rotate_radians", sk_canvas_rotate_radians}, // SkiaSharp
{"sk_canvas_save", sk_canvas_save}, // SkiaSharp
{"sk_canvas_save_layer", sk_canvas_save_layer}, // SkiaSharp
{"sk_canvas_scale", sk_canvas_scale}, // SkiaSharp
{"sk_canvas_set_matrix", sk_canvas_set_matrix}, // SkiaSharp
{"sk_canvas_skew", sk_canvas_skew}, // SkiaSharp
{"sk_canvas_translate", sk_canvas_translate}, // SkiaSharp
{"sk_codec_destroy", sk_codec_destroy}, // SkiaSharp
{"sk_codec_get_encoded_format", sk_codec_get_encoded_format}, // SkiaSharp
{"sk_codec_get_frame_count", sk_codec_get_frame_count}, // SkiaSharp
{"sk_codec_get_frame_info", sk_codec_get_frame_info}, // SkiaSharp
{"sk_codec_get_frame_info_for_index", sk_codec_get_frame_info_for_index}, // SkiaSharp
{"sk_codec_get_info", sk_codec_get_info}, // SkiaSharp
{"sk_codec_get_origin", sk_codec_get_origin}, // SkiaSharp
{"sk_codec_get_pixels", sk_codec_get_pixels}, // SkiaSharp
{"sk_codec_get_repetition_count", sk_codec_get_repetition_count}, // SkiaSharp
{"sk_codec_get_scaled_dimensions", sk_codec_get_scaled_dimensions}, // SkiaSharp
{"sk_codec_get_scanline_order", sk_codec_get_scanline_order}, // SkiaSharp
{"sk_codec_get_scanlines", sk_codec_get_scanlines}, // SkiaSharp
{"sk_codec_get_valid_subset", sk_codec_get_valid_subset}, // SkiaSharp
{"sk_codec_incremental_decode", sk_codec_incremental_decode}, // SkiaSharp
{"sk_codec_min_buffered_bytes_needed", sk_codec_min_buffered_bytes_needed}, // SkiaSharp
{"sk_codec_new_from_data", sk_codec_new_from_data}, // SkiaSharp
{"sk_codec_new_from_stream", sk_codec_new_from_stream}, // SkiaSharp
{"sk_codec_next_scanline", sk_codec_next_scanline}, // SkiaSharp
{"sk_codec_output_scanline", sk_codec_output_scanline}, // SkiaSharp
{"sk_codec_skip_scanlines", sk_codec_skip_scanlines}, // SkiaSharp
{"sk_codec_start_incremental_decode", sk_codec_start_incremental_decode}, // SkiaSharp
{"sk_codec_start_scanline_decode", sk_codec_start_scanline_decode}, // SkiaSharp
{"sk_color_get_bit_shift", sk_color_get_bit_shift}, // SkiaSharp
{"sk_color_premultiply", sk_color_premultiply}, // SkiaSharp
{"sk_color_premultiply_array", sk_color_premultiply_array}, // SkiaSharp
{"sk_color_unpremultiply", sk_color_unpremultiply}, // SkiaSharp
{"sk_color_unpremultiply_array", sk_color_unpremultiply_array}, // SkiaSharp
{"sk_color4f_from_color", sk_color4f_from_color}, // SkiaSharp
{"sk_color4f_to_color", sk_color4f_to_color}, // SkiaSharp
{"sk_colorfilter_new_color_matrix", sk_colorfilter_new_color_matrix}, // SkiaSharp
{"sk_colorfilter_new_compose", sk_colorfilter_new_compose}, // SkiaSharp
{"sk_colorfilter_new_high_contrast", sk_colorfilter_new_high_contrast}, // SkiaSharp
{"sk_colorfilter_new_lighting", sk_colorfilter_new_lighting}, // SkiaSharp
{"sk_colorfilter_new_luma_color", sk_colorfilter_new_luma_color}, // SkiaSharp
{"sk_colorfilter_new_mode", sk_colorfilter_new_mode}, // SkiaSharp
{"sk_colorfilter_new_table", sk_colorfilter_new_table}, // SkiaSharp
{"sk_colorfilter_new_table_argb", sk_colorfilter_new_table_argb}, // SkiaSharp
{"sk_colorfilter_unref", sk_colorfilter_unref}, // SkiaSharp
{"sk_colorspace_equals", sk_colorspace_equals}, // SkiaSharp
{"sk_colorspace_gamma_close_to_srgb", sk_colorspace_gamma_close_to_srgb}, // SkiaSharp
{"sk_colorspace_gamma_is_linear", sk_colorspace_gamma_is_linear}, // SkiaSharp
{"sk_colorspace_icc_profile_delete", sk_colorspace_icc_profile_delete}, // SkiaSharp
{"sk_colorspace_icc_profile_get_buffer", sk_colorspace_icc_profile_get_buffer}, // SkiaSharp
{"sk_colorspace_icc_profile_get_to_xyzd50", sk_colorspace_icc_profile_get_to_xyzd50}, // SkiaSharp
{"sk_colorspace_icc_profile_new", sk_colorspace_icc_profile_new}, // SkiaSharp
{"sk_colorspace_icc_profile_parse", sk_colorspace_icc_profile_parse}, // SkiaSharp
{"sk_colorspace_is_numerical_transfer_fn", sk_colorspace_is_numerical_transfer_fn}, // SkiaSharp
{"sk_colorspace_is_srgb", sk_colorspace_is_srgb}, // SkiaSharp
{"sk_colorspace_make_linear_gamma", sk_colorspace_make_linear_gamma}, // SkiaSharp
{"sk_colorspace_make_srgb_gamma", sk_colorspace_make_srgb_gamma}, // SkiaSharp
{"sk_colorspace_new_icc", sk_colorspace_new_icc}, // SkiaSharp
{"sk_colorspace_new_rgb", sk_colorspace_new_rgb}, // SkiaSharp
{"sk_colorspace_new_srgb", sk_colorspace_new_srgb}, // SkiaSharp
{"sk_colorspace_new_srgb_linear", sk_colorspace_new_srgb_linear}, // SkiaSharp
{"sk_colorspace_primaries_to_xyzd50", sk_colorspace_primaries_to_xyzd50}, // SkiaSharp
{"sk_colorspace_ref", sk_colorspace_ref}, // SkiaSharp
{"sk_colorspace_to_profile", sk_colorspace_to_profile}, // SkiaSharp
{"sk_colorspace_to_xyzd50", sk_colorspace_to_xyzd50}, // SkiaSharp
{"sk_colorspace_transfer_fn_eval", sk_colorspace_transfer_fn_eval}, // SkiaSharp
{"sk_colorspace_transfer_fn_invert", sk_colorspace_transfer_fn_invert}, // SkiaSharp
{"sk_colorspace_transfer_fn_named_2dot2", sk_colorspace_transfer_fn_named_2dot2}, // SkiaSharp
{"sk_colorspace_transfer_fn_named_hlg", sk_colorspace_transfer_fn_named_hlg}, // SkiaSharp
{"sk_colorspace_transfer_fn_named_linear", sk_colorspace_transfer_fn_named_linear}, // SkiaSharp
{"sk_colorspace_transfer_fn_named_pq", sk_colorspace_transfer_fn_named_pq}, // SkiaSharp
{"sk_colorspace_transfer_fn_named_rec2020", sk_colorspace_transfer_fn_named_rec2020}, // SkiaSharp
{"sk_colorspace_transfer_fn_named_srgb", sk_colorspace_transfer_fn_named_srgb}, // SkiaSharp
{"sk_colorspace_unref", sk_colorspace_unref}, // SkiaSharp
{"sk_colorspace_xyz_concat", sk_colorspace_xyz_concat}, // SkiaSharp
{"sk_colorspace_xyz_invert", sk_colorspace_xyz_invert}, // SkiaSharp
{"sk_colorspace_xyz_named_adobe_rgb", sk_colorspace_xyz_named_adobe_rgb}, // SkiaSharp
{"sk_colorspace_xyz_named_display_p3", sk_colorspace_xyz_named_display_p3}, // SkiaSharp
{"sk_colorspace_xyz_named_rec2020", sk_colorspace_xyz_named_rec2020}, // SkiaSharp
{"sk_colorspace_xyz_named_srgb", sk_colorspace_xyz_named_srgb}, // SkiaSharp
{"sk_colorspace_xyz_named_xyz", sk_colorspace_xyz_named_xyz}, // SkiaSharp
{"sk_colortable_count", sk_colortable_count}, // SkiaSharp
{"sk_colortable_new", sk_colortable_new}, // SkiaSharp
{"sk_colortable_read_colors", sk_colortable_read_colors}, // SkiaSharp
{"sk_colortable_unref", sk_colortable_unref}, // SkiaSharp
{"sk_colortype_get_default_8888", sk_colortype_get_default_8888}, // SkiaSharp
{"sk_compatpaint_clone", sk_compatpaint_clone}, // SkiaSharp
{"sk_compatpaint_delete", sk_compatpaint_delete}, // SkiaSharp
{"sk_compatpaint_get_font", sk_compatpaint_get_font}, // SkiaSharp
{"sk_compatpaint_get_text_align", sk_compatpaint_get_text_align}, // SkiaSharp
{"sk_compatpaint_get_text_encoding", sk_compatpaint_get_text_encoding}, // SkiaSharp
{"sk_compatpaint_make_font", sk_compatpaint_make_font}, // SkiaSharp
{"sk_compatpaint_new", sk_compatpaint_new}, // SkiaSharp
{"sk_compatpaint_new_with_font", sk_compatpaint_new_with_font}, // SkiaSharp
{"sk_compatpaint_reset", sk_compatpaint_reset}, // SkiaSharp
{"sk_compatpaint_set_text_align", sk_compatpaint_set_text_align}, // SkiaSharp
{"sk_compatpaint_set_text_encoding", sk_compatpaint_set_text_encoding}, // SkiaSharp
{"sk_data_get_bytes", sk_data_get_bytes}, // SkiaSharp
{"sk_data_get_data", sk_data_get_data}, // SkiaSharp
{"sk_data_get_size", sk_data_get_size}, // SkiaSharp
{"sk_data_new_empty", sk_data_new_empty}, // SkiaSharp
{"sk_data_new_from_file", sk_data_new_from_file}, // SkiaSharp
{"sk_data_new_from_stream", sk_data_new_from_stream}, // SkiaSharp
{"sk_data_new_subset", sk_data_new_subset}, // SkiaSharp
{"sk_data_new_uninitialized", sk_data_new_uninitialized}, // SkiaSharp
{"sk_data_new_with_copy", sk_data_new_with_copy}, // SkiaSharp
{"sk_data_new_with_proc", sk_data_new_with_proc}, // SkiaSharp
{"sk_data_ref", sk_data_ref}, // SkiaSharp
{"sk_data_unref", sk_data_unref}, // SkiaSharp
{"sk_document_abort", sk_document_abort}, // SkiaSharp
{"sk_document_begin_page", sk_document_begin_page}, // SkiaSharp
{"sk_document_close", sk_document_close}, // SkiaSharp
{"sk_document_create_pdf_from_stream", sk_document_create_pdf_from_stream}, // SkiaSharp
{"sk_document_create_pdf_from_stream_with_metadata", sk_document_create_pdf_from_stream_with_metadata}, // SkiaSharp
{"sk_document_create_xps_from_stream", sk_document_create_xps_from_stream}, // SkiaSharp
{"sk_document_end_page", sk_document_end_page}, // SkiaSharp
{"sk_document_unref", sk_document_unref}, // SkiaSharp
{"sk_drawable_draw", sk_drawable_draw}, // SkiaSharp
{"sk_drawable_get_bounds", sk_drawable_get_bounds}, // SkiaSharp
{"sk_drawable_get_generation_id", sk_drawable_get_generation_id}, // SkiaSharp
{"sk_drawable_new_picture_snapshot", sk_drawable_new_picture_snapshot}, // SkiaSharp
{"sk_drawable_notify_drawing_changed", sk_drawable_notify_drawing_changed}, // SkiaSharp
{"sk_drawable_unref", sk_drawable_unref}, // SkiaSharp
{"sk_dynamicmemorywstream_copy_to", sk_dynamicmemorywstream_copy_to}, // SkiaSharp
{"sk_dynamicmemorywstream_destroy", sk_dynamicmemorywstream_destroy}, // SkiaSharp
{"sk_dynamicmemorywstream_detach_as_data", sk_dynamicmemorywstream_detach_as_data}, // SkiaSharp
{"sk_dynamicmemorywstream_detach_as_stream", sk_dynamicmemorywstream_detach_as_stream}, // SkiaSharp
{"sk_dynamicmemorywstream_new", sk_dynamicmemorywstream_new}, // SkiaSharp
{"sk_dynamicmemorywstream_write_to_stream", sk_dynamicmemorywstream_write_to_stream}, // SkiaSharp
{"sk_filestream_destroy", sk_filestream_destroy}, // SkiaSharp
{"sk_filestream_is_valid", sk_filestream_is_valid}, // SkiaSharp
{"sk_filestream_new", sk_filestream_new}, // SkiaSharp
{"sk_filewstream_destroy", sk_filewstream_destroy}, // SkiaSharp
{"sk_filewstream_is_valid", sk_filewstream_is_valid}, // SkiaSharp
{"sk_filewstream_new", sk_filewstream_new}, // SkiaSharp
{"sk_font_break_text", sk_font_break_text}, // SkiaSharp
{"sk_font_delete", sk_font_delete}, // SkiaSharp
{"sk_font_get_edging", sk_font_get_edging}, // SkiaSharp
{"sk_font_get_hinting", sk_font_get_hinting}, // SkiaSharp
{"sk_font_get_metrics", sk_font_get_metrics}, // SkiaSharp
{"sk_font_get_path", sk_font_get_path}, // SkiaSharp
{"sk_font_get_paths", sk_font_get_paths}, // SkiaSharp
{"sk_font_get_pos", sk_font_get_pos}, // SkiaSharp
{"sk_font_get_scale_x", sk_font_get_scale_x}, // SkiaSharp
{"sk_font_get_size", sk_font_get_size}, // SkiaSharp
{"sk_font_get_skew_x", sk_font_get_skew_x}, // SkiaSharp
{"sk_font_get_typeface", sk_font_get_typeface}, // SkiaSharp
{"sk_font_get_widths_bounds", sk_font_get_widths_bounds}, // SkiaSharp
{"sk_font_get_xpos", sk_font_get_xpos}, // SkiaSharp
{"sk_font_is_baseline_snap", sk_font_is_baseline_snap}, // SkiaSharp
{"sk_font_is_embedded_bitmaps", sk_font_is_embedded_bitmaps}, // SkiaSharp
{"sk_font_is_embolden", sk_font_is_embolden}, // SkiaSharp
{"sk_font_is_force_auto_hinting", sk_font_is_force_auto_hinting}, // SkiaSharp
{"sk_font_is_linear_metrics", sk_font_is_linear_metrics}, // SkiaSharp
{"sk_font_is_subpixel", sk_font_is_subpixel}, // SkiaSharp
{"sk_font_measure_text", sk_font_measure_text}, // SkiaSharp
{"sk_font_measure_text_no_return", sk_font_measure_text_no_return}, // SkiaSharp
{"sk_font_new", sk_font_new}, // SkiaSharp
{"sk_font_new_with_values", sk_font_new_with_values}, // SkiaSharp
{"sk_font_set_baseline_snap", sk_font_set_baseline_snap}, // SkiaSharp
{"sk_font_set_edging", sk_font_set_edging}, // SkiaSharp
{"sk_font_set_embedded_bitmaps", sk_font_set_embedded_bitmaps}, // SkiaSharp
{"sk_font_set_embolden", sk_font_set_embolden}, // SkiaSharp
{"sk_font_set_force_auto_hinting", sk_font_set_force_auto_hinting}, // SkiaSharp
{"sk_font_set_hinting", sk_font_set_hinting}, // SkiaSharp
{"sk_font_set_linear_metrics", sk_font_set_linear_metrics}, // SkiaSharp
{"sk_font_set_scale_x", sk_font_set_scale_x}, // SkiaSharp
{"sk_font_set_size", sk_font_set_size}, // SkiaSharp
{"sk_font_set_skew_x", sk_font_set_skew_x}, // SkiaSharp
{"sk_font_set_subpixel", sk_font_set_subpixel}, // SkiaSharp
{"sk_font_set_typeface", sk_font_set_typeface}, // SkiaSharp
{"sk_font_text_to_glyphs", sk_font_text_to_glyphs}, // SkiaSharp
{"sk_font_unichar_to_glyph", sk_font_unichar_to_glyph}, // SkiaSharp
{"sk_font_unichars_to_glyphs", sk_font_unichars_to_glyphs}, // SkiaSharp
{"sk_fontmgr_count_families", sk_fontmgr_count_families}, // SkiaSharp
{"sk_fontmgr_create_default", sk_fontmgr_create_default}, // SkiaSharp
{"sk_fontmgr_create_from_data", sk_fontmgr_create_from_data}, // SkiaSharp
{"sk_fontmgr_create_from_file", sk_fontmgr_create_from_file}, // SkiaSharp
{"sk_fontmgr_create_from_stream", sk_fontmgr_create_from_stream}, // SkiaSharp
{"sk_fontmgr_create_styleset", sk_fontmgr_create_styleset}, // SkiaSharp
{"sk_fontmgr_get_family_name", sk_fontmgr_get_family_name}, // SkiaSharp
{"sk_fontmgr_match_face_style", sk_fontmgr_match_face_style}, // SkiaSharp
{"sk_fontmgr_match_family", sk_fontmgr_match_family}, // SkiaSharp
{"sk_fontmgr_match_family_style", sk_fontmgr_match_family_style}, // SkiaSharp
{"sk_fontmgr_match_family_style_character", sk_fontmgr_match_family_style_character}, // SkiaSharp
{"sk_fontmgr_ref_default", sk_fontmgr_ref_default}, // SkiaSharp
{"sk_fontmgr_unref", sk_fontmgr_unref}, // SkiaSharp
{"sk_fontstyle_delete", sk_fontstyle_delete}, // SkiaSharp
{"sk_fontstyle_get_slant", sk_fontstyle_get_slant}, // SkiaSharp
{"sk_fontstyle_get_weight", sk_fontstyle_get_weight}, // SkiaSharp
{"sk_fontstyle_get_width", sk_fontstyle_get_width}, // SkiaSharp
{"sk_fontstyle_new", sk_fontstyle_new}, // SkiaSharp
{"sk_fontstyleset_create_empty", sk_fontstyleset_create_empty}, // SkiaSharp
{"sk_fontstyleset_create_typeface", sk_fontstyleset_create_typeface}, // SkiaSharp
{"sk_fontstyleset_get_count", sk_fontstyleset_get_count}, // SkiaSharp
{"sk_fontstyleset_get_style", sk_fontstyleset_get_style}, // SkiaSharp
{"sk_fontstyleset_match_style", sk_fontstyleset_match_style}, // SkiaSharp
{"sk_fontstyleset_unref", sk_fontstyleset_unref}, // SkiaSharp
{"sk_graphics_dump_memory_statistics", sk_graphics_dump_memory_statistics}, // SkiaSharp
{"sk_graphics_get_font_cache_count_limit", sk_graphics_get_font_cache_count_limit}, // SkiaSharp
{"sk_graphics_get_font_cache_count_used", sk_graphics_get_font_cache_count_used}, // SkiaSharp
{"sk_graphics_get_font_cache_limit", sk_graphics_get_font_cache_limit}, // SkiaSharp
{"sk_graphics_get_font_cache_point_size_limit", sk_graphics_get_font_cache_point_size_limit}, // SkiaSharp
{"sk_graphics_get_font_cache_used", sk_graphics_get_font_cache_used}, // SkiaSharp
{"sk_graphics_get_resource_cache_single_allocation_byte_limit", sk_graphics_get_resource_cache_single_allocation_byte_limit}, // SkiaSharp
{"sk_graphics_get_resource_cache_total_byte_limit", sk_graphics_get_resource_cache_total_byte_limit}, // SkiaSharp
{"sk_graphics_get_resource_cache_total_bytes_used", sk_graphics_get_resource_cache_total_bytes_used}, // SkiaSharp
{"sk_graphics_init", sk_graphics_init}, // SkiaSharp
{"sk_graphics_purge_all_caches", sk_graphics_purge_all_caches}, // SkiaSharp
{"sk_graphics_purge_font_cache", sk_graphics_purge_font_cache}, // SkiaSharp
{"sk_graphics_purge_resource_cache", sk_graphics_purge_resource_cache}, // SkiaSharp
{"sk_graphics_set_font_cache_count_limit", sk_graphics_set_font_cache_count_limit}, // SkiaSharp
{"sk_graphics_set_font_cache_limit", sk_graphics_set_font_cache_limit}, // SkiaSharp
{"sk_graphics_set_font_cache_point_size_limit", sk_graphics_set_font_cache_point_size_limit}, // SkiaSharp
{"sk_graphics_set_resource_cache_single_allocation_byte_limit", sk_graphics_set_resource_cache_single_allocation_byte_limit}, // SkiaSharp
{"sk_graphics_set_resource_cache_total_byte_limit", sk_graphics_set_resource_cache_total_byte_limit}, // SkiaSharp
{"sk_image_encode", sk_image_encode}, // SkiaSharp
{"sk_image_encode_specific", sk_image_encode_specific}, // SkiaSharp
{"sk_image_get_alpha_type", sk_image_get_alpha_type}, // SkiaSharp
{"sk_image_get_color_type", sk_image_get_color_type}, // SkiaSharp
{"sk_image_get_colorspace", sk_image_get_colorspace}, // SkiaSharp
{"sk_image_get_height", sk_image_get_height}, // SkiaSharp
{"sk_image_get_unique_id", sk_image_get_unique_id}, // SkiaSharp
{"sk_image_get_width", sk_image_get_width}, // SkiaSharp
{"sk_image_is_alpha_only", sk_image_is_alpha_only}, // SkiaSharp
{"sk_image_is_lazy_generated", sk_image_is_lazy_generated}, // SkiaSharp
{"sk_image_is_texture_backed", sk_image_is_texture_backed}, // SkiaSharp
{"sk_image_is_valid", sk_image_is_valid}, // SkiaSharp
{"sk_image_make_non_texture_image", sk_image_make_non_texture_image}, // SkiaSharp
{"sk_image_make_raster_image", sk_image_make_raster_image}, // SkiaSharp
{"sk_image_make_shader", sk_image_make_shader}, // SkiaSharp
{"sk_image_make_subset", sk_image_make_subset}, // SkiaSharp
{"sk_image_make_texture_image", sk_image_make_texture_image}, // SkiaSharp
{"sk_image_make_with_filter", sk_image_make_with_filter}, // SkiaSharp
{"sk_image_make_with_filter_legacy", sk_image_make_with_filter_legacy}, // SkiaSharp
{"sk_image_new_from_adopted_texture", sk_image_new_from_adopted_texture}, // SkiaSharp
{"sk_image_new_from_bitmap", sk_image_new_from_bitmap}, // SkiaSharp
{"sk_image_new_from_encoded", sk_image_new_from_encoded}, // SkiaSharp
{"sk_image_new_from_picture", sk_image_new_from_picture}, // SkiaSharp
{"sk_image_new_from_texture", sk_image_new_from_texture}, // SkiaSharp
{"sk_image_new_raster", sk_image_new_raster}, // SkiaSharp
{"sk_image_new_raster_copy", sk_image_new_raster_copy}, // SkiaSharp
{"sk_image_new_raster_copy_with_pixmap", sk_image_new_raster_copy_with_pixmap}, // SkiaSharp
{"sk_image_new_raster_data", sk_image_new_raster_data}, // SkiaSharp
{"sk_image_peek_pixels", sk_image_peek_pixels}, // SkiaSharp
{"sk_image_read_pixels", sk_image_read_pixels}, // SkiaSharp
{"sk_image_read_pixels_into_pixmap", sk_image_read_pixels_into_pixmap}, // SkiaSharp
{"sk_image_ref", sk_image_ref}, // SkiaSharp
{"sk_image_ref_encoded", sk_image_ref_encoded}, // SkiaSharp
{"sk_image_scale_pixels", sk_image_scale_pixels}, // SkiaSharp
{"sk_image_unref", sk_image_unref}, // SkiaSharp
{"sk_imagefilter_croprect_destructor", sk_imagefilter_croprect_destructor}, // SkiaSharp
{"sk_imagefilter_croprect_get_flags", sk_imagefilter_croprect_get_flags}, // SkiaSharp
{"sk_imagefilter_croprect_get_rect", sk_imagefilter_croprect_get_rect}, // SkiaSharp
{"sk_imagefilter_croprect_new", sk_imagefilter_croprect_new}, // SkiaSharp
{"sk_imagefilter_croprect_new_with_rect", sk_imagefilter_croprect_new_with_rect}, // SkiaSharp
{"sk_imagefilter_new_alpha_threshold", sk_imagefilter_new_alpha_threshold}, // SkiaSharp
{"sk_imagefilter_new_arithmetic", sk_imagefilter_new_arithmetic}, // SkiaSharp
{"sk_imagefilter_new_blur", sk_imagefilter_new_blur}, // SkiaSharp
{"sk_imagefilter_new_color_filter", sk_imagefilter_new_color_filter}, // SkiaSharp
{"sk_imagefilter_new_compose", sk_imagefilter_new_compose}, // SkiaSharp
{"sk_imagefilter_new_dilate", sk_imagefilter_new_dilate}, // SkiaSharp
{"sk_imagefilter_new_displacement_map_effect", sk_imagefilter_new_displacement_map_effect}, // SkiaSharp
{"sk_imagefilter_new_distant_lit_diffuse", sk_imagefilter_new_distant_lit_diffuse}, // SkiaSharp
{"sk_imagefilter_new_distant_lit_specular", sk_imagefilter_new_distant_lit_specular}, // SkiaSharp
{"sk_imagefilter_new_drop_shadow", sk_imagefilter_new_drop_shadow}, // SkiaSharp
{"sk_imagefilter_new_drop_shadow_only", sk_imagefilter_new_drop_shadow_only}, // SkiaSharp
{"sk_imagefilter_new_erode", sk_imagefilter_new_erode}, // SkiaSharp
{"sk_imagefilter_new_image_source", sk_imagefilter_new_image_source}, // SkiaSharp
{"sk_imagefilter_new_image_source_default", sk_imagefilter_new_image_source_default}, // SkiaSharp
{"sk_imagefilter_new_magnifier", sk_imagefilter_new_magnifier}, // SkiaSharp
{"sk_imagefilter_new_matrix", sk_imagefilter_new_matrix}, // SkiaSharp
{"sk_imagefilter_new_matrix_convolution", sk_imagefilter_new_matrix_convolution}, // SkiaSharp
{"sk_imagefilter_new_merge", sk_imagefilter_new_merge}, // SkiaSharp
{"sk_imagefilter_new_offset", sk_imagefilter_new_offset}, // SkiaSharp
{"sk_imagefilter_new_paint", sk_imagefilter_new_paint}, // SkiaSharp
{"sk_imagefilter_new_picture", sk_imagefilter_new_picture}, // SkiaSharp
{"sk_imagefilter_new_picture_with_croprect", sk_imagefilter_new_picture_with_croprect}, // SkiaSharp
{"sk_imagefilter_new_point_lit_diffuse", sk_imagefilter_new_point_lit_diffuse}, // SkiaSharp
{"sk_imagefilter_new_point_lit_specular", sk_imagefilter_new_point_lit_specular}, // SkiaSharp
{"sk_imagefilter_new_spot_lit_diffuse", sk_imagefilter_new_spot_lit_diffuse}, // SkiaSharp
{"sk_imagefilter_new_spot_lit_specular", sk_imagefilter_new_spot_lit_specular}, // SkiaSharp
{"sk_imagefilter_new_tile", sk_imagefilter_new_tile}, // SkiaSharp
{"sk_imagefilter_new_xfermode", sk_imagefilter_new_xfermode}, // SkiaSharp
{"sk_imagefilter_unref", sk_imagefilter_unref}, // SkiaSharp
{"sk_jpegencoder_encode", sk_jpegencoder_encode}, // SkiaSharp
{"sk_manageddrawable_new", sk_manageddrawable_new}, // SkiaSharp
{"sk_manageddrawable_set_procs", sk_manageddrawable_set_procs}, // SkiaSharp
{"sk_manageddrawable_unref", sk_manageddrawable_unref}, // SkiaSharp
{"sk_managedstream_destroy", sk_managedstream_destroy}, // SkiaSharp
{"sk_managedstream_new", sk_managedstream_new}, // SkiaSharp
{"sk_managedstream_set_procs", sk_managedstream_set_procs}, // SkiaSharp
{"sk_managedtracememorydump_delete", sk_managedtracememorydump_delete}, // SkiaSharp
{"sk_managedtracememorydump_new", sk_managedtracememorydump_new}, // SkiaSharp
{"sk_managedtracememorydump_set_procs", sk_managedtracememorydump_set_procs}, // SkiaSharp
{"sk_managedwstream_destroy", sk_managedwstream_destroy}, // SkiaSharp
{"sk_managedwstream_new", sk_managedwstream_new}, // SkiaSharp
{"sk_managedwstream_set_procs", sk_managedwstream_set_procs}, // SkiaSharp
{"sk_mask_alloc_image", sk_mask_alloc_image}, // SkiaSharp
{"sk_mask_compute_image_size", sk_mask_compute_image_size}, // SkiaSharp
{"sk_mask_compute_total_image_size", sk_mask_compute_total_image_size}, // SkiaSharp
{"sk_mask_free_image", sk_mask_free_image}, // SkiaSharp
{"sk_mask_get_addr", sk_mask_get_addr}, // SkiaSharp
{"sk_mask_get_addr_1", sk_mask_get_addr_1}, // SkiaSharp
{"sk_mask_get_addr_32", sk_mask_get_addr_32}, // SkiaSharp
{"sk_mask_get_addr_8", sk_mask_get_addr_8}, // SkiaSharp
{"sk_mask_get_addr_lcd_16", sk_mask_get_addr_lcd_16}, // SkiaSharp
{"sk_mask_is_empty", sk_mask_is_empty}, // SkiaSharp
{"sk_maskfilter_new_blur", sk_maskfilter_new_blur}, // SkiaSharp
{"sk_maskfilter_new_blur_with_flags", sk_maskfilter_new_blur_with_flags}, // SkiaSharp
{"sk_maskfilter_new_clip", sk_maskfilter_new_clip}, // SkiaSharp
{"sk_maskfilter_new_gamma", sk_maskfilter_new_gamma}, // SkiaSharp
{"sk_maskfilter_new_shader", sk_maskfilter_new_shader}, // SkiaSharp
{"sk_maskfilter_new_table", sk_maskfilter_new_table}, // SkiaSharp
{"sk_maskfilter_ref", sk_maskfilter_ref}, // SkiaSharp
{"sk_maskfilter_unref", sk_maskfilter_unref}, // SkiaSharp
{"sk_matrix_concat", sk_matrix_concat}, // SkiaSharp
{"sk_matrix_map_points", sk_matrix_map_points}, // SkiaSharp
{"sk_matrix_map_radius", sk_matrix_map_radius}, // SkiaSharp
{"sk_matrix_map_rect", sk_matrix_map_rect}, // SkiaSharp
{"sk_matrix_map_vector", sk_matrix_map_vector}, // SkiaSharp
{"sk_matrix_map_vectors", sk_matrix_map_vectors}, // SkiaSharp
{"sk_matrix_map_xy", sk_matrix_map_xy}, // SkiaSharp
{"sk_matrix_post_concat", sk_matrix_post_concat}, // SkiaSharp
{"sk_matrix_pre_concat", sk_matrix_pre_concat}, // SkiaSharp
{"sk_matrix_try_invert", sk_matrix_try_invert}, // SkiaSharp
{"sk_matrix44_as_col_major", sk_matrix44_as_col_major}, // SkiaSharp
{"sk_matrix44_as_row_major", sk_matrix44_as_row_major}, // SkiaSharp
{"sk_matrix44_destroy", sk_matrix44_destroy}, // SkiaSharp
{"sk_matrix44_determinant", sk_matrix44_determinant}, // SkiaSharp
{"sk_matrix44_equals", sk_matrix44_equals}, // SkiaSharp
{"sk_matrix44_get", sk_matrix44_get}, // SkiaSharp
{"sk_matrix44_get_type", sk_matrix44_get_type}, // SkiaSharp
{"sk_matrix44_invert", sk_matrix44_invert}, // SkiaSharp
{"sk_matrix44_map_scalars", sk_matrix44_map_scalars}, // SkiaSharp
{"sk_matrix44_map2", sk_matrix44_map2}, // SkiaSharp
{"sk_matrix44_new", sk_matrix44_new}, // SkiaSharp
{"sk_matrix44_new_concat", sk_matrix44_new_concat}, // SkiaSharp
{"sk_matrix44_new_copy", sk_matrix44_new_copy}, // SkiaSharp
{"sk_matrix44_new_identity", sk_matrix44_new_identity}, // SkiaSharp
{"sk_matrix44_new_matrix", sk_matrix44_new_matrix}, // SkiaSharp
{"sk_matrix44_post_concat", sk_matrix44_post_concat}, // SkiaSharp
{"sk_matrix44_post_scale", sk_matrix44_post_scale}, // SkiaSharp
{"sk_matrix44_post_translate", sk_matrix44_post_translate}, // SkiaSharp
{"sk_matrix44_pre_concat", sk_matrix44_pre_concat}, // SkiaSharp
{"sk_matrix44_pre_scale", sk_matrix44_pre_scale}, // SkiaSharp
{"sk_matrix44_pre_translate", sk_matrix44_pre_translate}, // SkiaSharp
{"sk_matrix44_preserves_2d_axis_alignment", sk_matrix44_preserves_2d_axis_alignment}, // SkiaSharp
{"sk_matrix44_set", sk_matrix44_set}, // SkiaSharp
{"sk_matrix44_set_3x3_row_major", sk_matrix44_set_3x3_row_major}, // SkiaSharp
{"sk_matrix44_set_col_major", sk_matrix44_set_col_major}, // SkiaSharp
{"sk_matrix44_set_concat", sk_matrix44_set_concat}, // SkiaSharp
{"sk_matrix44_set_identity", sk_matrix44_set_identity}, // SkiaSharp
{"sk_matrix44_set_rotate_about_degrees", sk_matrix44_set_rotate_about_degrees}, // SkiaSharp
{"sk_matrix44_set_rotate_about_radians", sk_matrix44_set_rotate_about_radians}, // SkiaSharp
{"sk_matrix44_set_rotate_about_radians_unit", sk_matrix44_set_rotate_about_radians_unit}, // SkiaSharp
{"sk_matrix44_set_row_major", sk_matrix44_set_row_major}, // SkiaSharp
{"sk_matrix44_set_scale", sk_matrix44_set_scale}, // SkiaSharp
{"sk_matrix44_set_translate", sk_matrix44_set_translate}, // SkiaSharp
{"sk_matrix44_to_matrix", sk_matrix44_to_matrix}, // SkiaSharp
{"sk_matrix44_transpose", sk_matrix44_transpose}, // SkiaSharp
{"sk_memorystream_destroy", sk_memorystream_destroy}, // SkiaSharp
{"sk_memorystream_new", sk_memorystream_new}, // SkiaSharp
{"sk_memorystream_new_with_data", sk_memorystream_new_with_data}, // SkiaSharp
{"sk_memorystream_new_with_length", sk_memorystream_new_with_length}, // SkiaSharp
{"sk_memorystream_new_with_skdata", sk_memorystream_new_with_skdata}, // SkiaSharp
{"sk_memorystream_set_memory", sk_memorystream_set_memory}, // SkiaSharp
{"sk_nodraw_canvas_destroy", sk_nodraw_canvas_destroy}, // SkiaSharp
{"sk_nodraw_canvas_new", sk_nodraw_canvas_new}, // SkiaSharp
{"sk_nvrefcnt_get_ref_count", sk_nvrefcnt_get_ref_count}, // SkiaSharp
{"sk_nvrefcnt_safe_ref", sk_nvrefcnt_safe_ref}, // SkiaSharp
{"sk_nvrefcnt_safe_unref", sk_nvrefcnt_safe_unref}, // SkiaSharp
{"sk_nvrefcnt_unique", sk_nvrefcnt_unique}, // SkiaSharp
{"sk_nway_canvas_add_canvas", sk_nway_canvas_add_canvas}, // SkiaSharp
{"sk_nway_canvas_destroy", sk_nway_canvas_destroy}, // SkiaSharp
{"sk_nway_canvas_new", sk_nway_canvas_new}, // SkiaSharp
{"sk_nway_canvas_remove_all", sk_nway_canvas_remove_all}, // SkiaSharp
{"sk_nway_canvas_remove_canvas", sk_nway_canvas_remove_canvas}, // SkiaSharp
{"sk_opbuilder_add", sk_opbuilder_add}, // SkiaSharp
{"sk_opbuilder_destroy", sk_opbuilder_destroy}, // SkiaSharp
{"sk_opbuilder_new", sk_opbuilder_new}, // SkiaSharp
{"sk_opbuilder_resolve", sk_opbuilder_resolve}, // SkiaSharp
{"sk_overdraw_canvas_destroy", sk_overdraw_canvas_destroy}, // SkiaSharp
{"sk_overdraw_canvas_new", sk_overdraw_canvas_new}, // SkiaSharp
{"sk_paint_clone", sk_paint_clone}, // SkiaSharp
{"sk_paint_delete", sk_paint_delete}, // SkiaSharp
{"sk_paint_get_blendmode", sk_paint_get_blendmode}, // SkiaSharp
{"sk_paint_get_color", sk_paint_get_color}, // SkiaSharp
{"sk_paint_get_color4f", sk_paint_get_color4f}, // SkiaSharp
{"sk_paint_get_colorfilter", sk_paint_get_colorfilter}, // SkiaSharp
{"sk_paint_get_fill_path", sk_paint_get_fill_path}, // SkiaSharp
{"sk_paint_get_filter_quality", sk_paint_get_filter_quality}, // SkiaSharp
{"sk_paint_get_imagefilter", sk_paint_get_imagefilter}, // SkiaSharp
{"sk_paint_get_maskfilter", sk_paint_get_maskfilter}, // SkiaSharp
{"sk_paint_get_path_effect", sk_paint_get_path_effect}, // SkiaSharp
{"sk_paint_get_shader", sk_paint_get_shader}, // SkiaSharp
{"sk_paint_get_stroke_cap", sk_paint_get_stroke_cap}, // SkiaSharp
{"sk_paint_get_stroke_join", sk_paint_get_stroke_join}, // SkiaSharp
{"sk_paint_get_stroke_miter", sk_paint_get_stroke_miter}, // SkiaSharp
{"sk_paint_get_stroke_width", sk_paint_get_stroke_width}, // SkiaSharp
{"sk_paint_get_style", sk_paint_get_style}, // SkiaSharp
{"sk_paint_is_antialias", sk_paint_is_antialias}, // SkiaSharp
{"sk_paint_is_dither", sk_paint_is_dither}, // SkiaSharp
{"sk_paint_new", sk_paint_new}, // SkiaSharp
{"sk_paint_reset", sk_paint_reset}, // SkiaSharp
{"sk_paint_set_antialias", sk_paint_set_antialias}, // SkiaSharp
{"sk_paint_set_blendmode", sk_paint_set_blendmode}, // SkiaSharp
{"sk_paint_set_color", sk_paint_set_color}, // SkiaSharp
{"sk_paint_set_color4f", sk_paint_set_color4f}, // SkiaSharp
{"sk_paint_set_colorfilter", sk_paint_set_colorfilter}, // SkiaSharp
{"sk_paint_set_dither", sk_paint_set_dither}, // SkiaSharp
{"sk_paint_set_filter_quality", sk_paint_set_filter_quality}, // SkiaSharp
{"sk_paint_set_imagefilter", sk_paint_set_imagefilter}, // SkiaSharp
{"sk_paint_set_maskfilter", sk_paint_set_maskfilter}, // SkiaSharp
{"sk_paint_set_path_effect", sk_paint_set_path_effect}, // SkiaSharp
{"sk_paint_set_shader", sk_paint_set_shader}, // SkiaSharp
{"sk_paint_set_stroke_cap", sk_paint_set_stroke_cap}, // SkiaSharp
{"sk_paint_set_stroke_join", sk_paint_set_stroke_join}, // SkiaSharp
{"sk_paint_set_stroke_miter", sk_paint_set_stroke_miter}, // SkiaSharp
{"sk_paint_set_stroke_width", sk_paint_set_stroke_width}, // SkiaSharp
{"sk_paint_set_style", sk_paint_set_style}, // SkiaSharp
{"sk_path_add_arc", sk_path_add_arc}, // SkiaSharp
{"sk_path_add_circle", sk_path_add_circle}, // SkiaSharp
{"sk_path_add_oval", sk_path_add_oval}, // SkiaSharp
{"sk_path_add_path", sk_path_add_path}, // SkiaSharp
{"sk_path_add_path_matrix", sk_path_add_path_matrix}, // SkiaSharp
{"sk_path_add_path_offset", sk_path_add_path_offset}, // SkiaSharp
{"sk_path_add_path_reverse", sk_path_add_path_reverse}, // SkiaSharp
{"sk_path_add_poly", sk_path_add_poly}, // SkiaSharp
{"sk_path_add_rect", sk_path_add_rect}, // SkiaSharp
{"sk_path_add_rect_start", sk_path_add_rect_start}, // SkiaSharp
{"sk_path_add_rounded_rect", sk_path_add_rounded_rect}, // SkiaSharp
{"sk_path_add_rrect", sk_path_add_rrect}, // SkiaSharp
{"sk_path_add_rrect_start", sk_path_add_rrect_start}, // SkiaSharp
{"sk_path_arc_to", sk_path_arc_to}, // SkiaSharp
{"sk_path_arc_to_with_oval", sk_path_arc_to_with_oval}, // SkiaSharp
{"sk_path_arc_to_with_points", sk_path_arc_to_with_points}, // SkiaSharp
{"sk_path_clone", sk_path_clone}, // SkiaSharp
{"sk_path_close", sk_path_close}, // SkiaSharp
{"sk_path_compute_tight_bounds", sk_path_compute_tight_bounds}, // SkiaSharp
{"sk_path_conic_to", sk_path_conic_to}, // SkiaSharp
{"sk_path_contains", sk_path_contains}, // SkiaSharp
{"sk_path_convert_conic_to_quads", sk_path_convert_conic_to_quads}, // SkiaSharp
{"sk_path_count_points", sk_path_count_points}, // SkiaSharp
{"sk_path_count_verbs", sk_path_count_verbs}, // SkiaSharp
{"sk_path_create_iter", sk_path_create_iter}, // SkiaSharp
{"sk_path_create_rawiter", sk_path_create_rawiter}, // SkiaSharp
{"sk_path_cubic_to", sk_path_cubic_to}, // SkiaSharp
{"sk_path_delete", sk_path_delete}, // SkiaSharp
{"sk_path_effect_create_1d_path", sk_path_effect_create_1d_path}, // SkiaSharp
{"sk_path_effect_create_2d_line", sk_path_effect_create_2d_line}, // SkiaSharp
{"sk_path_effect_create_2d_path", sk_path_effect_create_2d_path}, // SkiaSharp
{"sk_path_effect_create_compose", sk_path_effect_create_compose}, // SkiaSharp
{"sk_path_effect_create_corner", sk_path_effect_create_corner}, // SkiaSharp
{"sk_path_effect_create_dash", sk_path_effect_create_dash}, // SkiaSharp
{"sk_path_effect_create_discrete", sk_path_effect_create_discrete}, // SkiaSharp
{"sk_path_effect_create_sum", sk_path_effect_create_sum}, // SkiaSharp
{"sk_path_effect_create_trim", sk_path_effect_create_trim}, // SkiaSharp
{"sk_path_effect_unref", sk_path_effect_unref}, // SkiaSharp
{"sk_path_get_bounds", sk_path_get_bounds}, // SkiaSharp
{"sk_path_get_filltype", sk_path_get_filltype}, // SkiaSharp
{"sk_path_get_last_point", sk_path_get_last_point}, // SkiaSharp
{"sk_path_get_point", sk_path_get_point}, // SkiaSharp
{"sk_path_get_points", sk_path_get_points}, // SkiaSharp
{"sk_path_get_segment_masks", sk_path_get_segment_masks}, // SkiaSharp
{"sk_path_is_convex", sk_path_is_convex}, // SkiaSharp
{"sk_path_is_line", sk_path_is_line}, // SkiaSharp
{"sk_path_is_oval", sk_path_is_oval}, // SkiaSharp
{"sk_path_is_rect", sk_path_is_rect}, // SkiaSharp
{"sk_path_is_rrect", sk_path_is_rrect}, // SkiaSharp
{"sk_path_iter_conic_weight", sk_path_iter_conic_weight}, // SkiaSharp
{"sk_path_iter_destroy", sk_path_iter_destroy}, // SkiaSharp
{"sk_path_iter_is_close_line", sk_path_iter_is_close_line}, // SkiaSharp
{"sk_path_iter_is_closed_contour", sk_path_iter_is_closed_contour}, // SkiaSharp
{"sk_path_iter_next", sk_path_iter_next}, // SkiaSharp
{"sk_path_line_to", sk_path_line_to}, // SkiaSharp
{"sk_path_move_to", sk_path_move_to}, // SkiaSharp
{"sk_path_new", sk_path_new}, // SkiaSharp
{"sk_path_parse_svg_string", sk_path_parse_svg_string}, // SkiaSharp
{"sk_path_quad_to", sk_path_quad_to}, // SkiaSharp
{"sk_path_rarc_to", sk_path_rarc_to}, // SkiaSharp
{"sk_path_rawiter_conic_weight", sk_path_rawiter_conic_weight}, // SkiaSharp
{"sk_path_rawiter_destroy", sk_path_rawiter_destroy}, // SkiaSharp
{"sk_path_rawiter_next", sk_path_rawiter_next}, // SkiaSharp
{"sk_path_rawiter_peek", sk_path_rawiter_peek}, // SkiaSharp
{"sk_path_rconic_to", sk_path_rconic_to}, // SkiaSharp
{"sk_path_rcubic_to", sk_path_rcubic_to}, // SkiaSharp
{"sk_path_reset", sk_path_reset}, // SkiaSharp
{"sk_path_rewind", sk_path_rewind}, // SkiaSharp
{"sk_path_rline_to", sk_path_rline_to}, // SkiaSharp
{"sk_path_rmove_to", sk_path_rmove_to}, // SkiaSharp
{"sk_path_rquad_to", sk_path_rquad_to}, // SkiaSharp
{"sk_path_set_filltype", sk_path_set_filltype}, // SkiaSharp
{"sk_path_to_svg_string", sk_path_to_svg_string}, // SkiaSharp
{"sk_path_transform", sk_path_transform}, // SkiaSharp
{"sk_path_transform_to_dest", sk_path_transform_to_dest}, // SkiaSharp
{"sk_pathmeasure_destroy", sk_pathmeasure_destroy}, // SkiaSharp
{"sk_pathmeasure_get_length", sk_pathmeasure_get_length}, // SkiaSharp
{"sk_pathmeasure_get_matrix", sk_pathmeasure_get_matrix}, // SkiaSharp
{"sk_pathmeasure_get_pos_tan", sk_pathmeasure_get_pos_tan}, // SkiaSharp
{"sk_pathmeasure_get_segment", sk_pathmeasure_get_segment}, // SkiaSharp
{"sk_pathmeasure_is_closed", sk_pathmeasure_is_closed}, // SkiaSharp
{"sk_pathmeasure_new", sk_pathmeasure_new}, // SkiaSharp
{"sk_pathmeasure_new_with_path", sk_pathmeasure_new_with_path}, // SkiaSharp
{"sk_pathmeasure_next_contour", sk_pathmeasure_next_contour}, // SkiaSharp
{"sk_pathmeasure_set_path", sk_pathmeasure_set_path}, // SkiaSharp
{"sk_pathop_as_winding", sk_pathop_as_winding}, // SkiaSharp
{"sk_pathop_op", sk_pathop_op}, // SkiaSharp
{"sk_pathop_simplify", sk_pathop_simplify}, // SkiaSharp
{"sk_pathop_tight_bounds", sk_pathop_tight_bounds}, // SkiaSharp
{"sk_picture_deserialize_from_data", sk_picture_deserialize_from_data}, // SkiaSharp
{"sk_picture_deserialize_from_memory", sk_picture_deserialize_from_memory}, // SkiaSharp
{"sk_picture_deserialize_from_stream", sk_picture_deserialize_from_stream}, // SkiaSharp
{"sk_picture_get_cull_rect", sk_picture_get_cull_rect}, // SkiaSharp
{"sk_picture_get_recording_canvas", sk_picture_get_recording_canvas}, // SkiaSharp
{"sk_picture_get_unique_id", sk_picture_get_unique_id}, // SkiaSharp
{"sk_picture_make_shader", sk_picture_make_shader}, // SkiaSharp
{"sk_picture_recorder_begin_recording", sk_picture_recorder_begin_recording}, // SkiaSharp
{"sk_picture_recorder_delete", sk_picture_recorder_delete}, // SkiaSharp
{"sk_picture_recorder_end_recording", sk_picture_recorder_end_recording}, // SkiaSharp
{"sk_picture_recorder_end_recording_as_drawable", sk_picture_recorder_end_recording_as_drawable}, // SkiaSharp
{"sk_picture_recorder_new", sk_picture_recorder_new}, // SkiaSharp
{"sk_picture_ref", sk_picture_ref}, // SkiaSharp
{"sk_picture_serialize_to_data", sk_picture_serialize_to_data}, // SkiaSharp
{"sk_picture_serialize_to_stream", sk_picture_serialize_to_stream}, // SkiaSharp
{"sk_picture_unref", sk_picture_unref}, // SkiaSharp
{"sk_pixmap_destructor", sk_pixmap_destructor}, // SkiaSharp
{"sk_pixmap_encode_image", sk_pixmap_encode_image}, // SkiaSharp
{"sk_pixmap_erase_color", sk_pixmap_erase_color}, // SkiaSharp
{"sk_pixmap_erase_color4f", sk_pixmap_erase_color4f}, // SkiaSharp
{"sk_pixmap_extract_subset", sk_pixmap_extract_subset}, // SkiaSharp
{"sk_pixmap_get_info", sk_pixmap_get_info}, // SkiaSharp
{"sk_pixmap_get_pixel_color", sk_pixmap_get_pixel_color}, // SkiaSharp
{"sk_pixmap_get_pixels", sk_pixmap_get_pixels}, // SkiaSharp
{"sk_pixmap_get_pixels_with_xy", sk_pixmap_get_pixels_with_xy}, // SkiaSharp
{"sk_pixmap_get_row_bytes", sk_pixmap_get_row_bytes}, // SkiaSharp
{"sk_pixmap_get_writable_addr", sk_pixmap_get_writable_addr}, // SkiaSharp
{"sk_pixmap_new", sk_pixmap_new}, // SkiaSharp
{"sk_pixmap_new_with_params", sk_pixmap_new_with_params}, // SkiaSharp
{"sk_pixmap_read_pixels", sk_pixmap_read_pixels}, // SkiaSharp
{"sk_pixmap_reset", sk_pixmap_reset}, // SkiaSharp
{"sk_pixmap_reset_with_params", sk_pixmap_reset_with_params}, // SkiaSharp
{"sk_pixmap_scale_pixels", sk_pixmap_scale_pixels}, // SkiaSharp
{"sk_pngencoder_encode", sk_pngencoder_encode}, // SkiaSharp
{"sk_refcnt_get_ref_count", sk_refcnt_get_ref_count}, // SkiaSharp
{"sk_refcnt_safe_ref", sk_refcnt_safe_ref}, // SkiaSharp
{"sk_refcnt_safe_unref", sk_refcnt_safe_unref}, // SkiaSharp
{"sk_refcnt_unique", sk_refcnt_unique}, // SkiaSharp
{"sk_region_cliperator_delete", sk_region_cliperator_delete}, // SkiaSharp
{"sk_region_cliperator_done", sk_region_cliperator_done}, // SkiaSharp
{"sk_region_cliperator_new", sk_region_cliperator_new}, // SkiaSharp
{"sk_region_cliperator_next", sk_region_cliperator_next}, // SkiaSharp
{"sk_region_cliperator_rect", sk_region_cliperator_rect}, // SkiaSharp
{"sk_region_contains", sk_region_contains}, // SkiaSharp
{"sk_region_contains_point", sk_region_contains_point}, // SkiaSharp
{"sk_region_contains_rect", sk_region_contains_rect}, // SkiaSharp
{"sk_region_delete", sk_region_delete}, // SkiaSharp
{"sk_region_get_boundary_path", sk_region_get_boundary_path}, // SkiaSharp
{"sk_region_get_bounds", sk_region_get_bounds}, // SkiaSharp
{"sk_region_intersects", sk_region_intersects}, // SkiaSharp
{"sk_region_intersects_rect", sk_region_intersects_rect}, // SkiaSharp
{"sk_region_is_complex", sk_region_is_complex}, // SkiaSharp
{"sk_region_is_empty", sk_region_is_empty}, // SkiaSharp
{"sk_region_is_rect", sk_region_is_rect}, // SkiaSharp
{"sk_region_iterator_delete", sk_region_iterator_delete}, // SkiaSharp
{"sk_region_iterator_done", sk_region_iterator_done}, // SkiaSharp
{"sk_region_iterator_new", sk_region_iterator_new}, // SkiaSharp
{"sk_region_iterator_next", sk_region_iterator_next}, // SkiaSharp
{"sk_region_iterator_rect", sk_region_iterator_rect}, // SkiaSharp
{"sk_region_iterator_rewind", sk_region_iterator_rewind}, // SkiaSharp
{"sk_region_new", sk_region_new}, // SkiaSharp
{"sk_region_op", sk_region_op}, // SkiaSharp
{"sk_region_op_rect", sk_region_op_rect}, // SkiaSharp
{"sk_region_quick_contains", sk_region_quick_contains}, // SkiaSharp
{"sk_region_quick_reject", sk_region_quick_reject}, // SkiaSharp
{"sk_region_quick_reject_rect", sk_region_quick_reject_rect}, // SkiaSharp
{"sk_region_set_empty", sk_region_set_empty}, // SkiaSharp
{"sk_region_set_path", sk_region_set_path}, // SkiaSharp
{"sk_region_set_rect", sk_region_set_rect}, // SkiaSharp
{"sk_region_set_rects", sk_region_set_rects}, // SkiaSharp
{"sk_region_set_region", sk_region_set_region}, // SkiaSharp
{"sk_region_spanerator_delete", sk_region_spanerator_delete}, // SkiaSharp
{"sk_region_spanerator_new", sk_region_spanerator_new}, // SkiaSharp
{"sk_region_spanerator_next", sk_region_spanerator_next}, // SkiaSharp
{"sk_region_translate", sk_region_translate}, // SkiaSharp
{"sk_rrect_contains", sk_rrect_contains}, // SkiaSharp
{"sk_rrect_delete", sk_rrect_delete}, // SkiaSharp
{"sk_rrect_get_height", sk_rrect_get_height}, // SkiaSharp
{"sk_rrect_get_radii", sk_rrect_get_radii}, // SkiaSharp
{"sk_rrect_get_rect", sk_rrect_get_rect}, // SkiaSharp
{"sk_rrect_get_type", sk_rrect_get_type}, // SkiaSharp
{"sk_rrect_get_width", sk_rrect_get_width}, // SkiaSharp
{"sk_rrect_inset", sk_rrect_inset}, // SkiaSharp
{"sk_rrect_is_valid", sk_rrect_is_valid}, // SkiaSharp
{"sk_rrect_new", sk_rrect_new}, // SkiaSharp
{"sk_rrect_new_copy", sk_rrect_new_copy}, // SkiaSharp
{"sk_rrect_offset", sk_rrect_offset}, // SkiaSharp
{"sk_rrect_outset", sk_rrect_outset}, // SkiaSharp
{"sk_rrect_set_empty", sk_rrect_set_empty}, // SkiaSharp
{"sk_rrect_set_nine_patch", sk_rrect_set_nine_patch}, // SkiaSharp
{"sk_rrect_set_oval", sk_rrect_set_oval}, // SkiaSharp
{"sk_rrect_set_rect", sk_rrect_set_rect}, // SkiaSharp
{"sk_rrect_set_rect_radii", sk_rrect_set_rect_radii}, // SkiaSharp
{"sk_rrect_set_rect_xy", sk_rrect_set_rect_xy}, // SkiaSharp
{"sk_rrect_transform", sk_rrect_transform}, // SkiaSharp
{"sk_runtimeeffect_get_child_name", sk_runtimeeffect_get_child_name}, // SkiaSharp
{"sk_runtimeeffect_get_children_count", sk_runtimeeffect_get_children_count}, // SkiaSharp
{"sk_runtimeeffect_get_uniform_from_index", sk_runtimeeffect_get_uniform_from_index}, // SkiaSharp
{"sk_runtimeeffect_get_uniform_from_name", sk_runtimeeffect_get_uniform_from_name}, // SkiaSharp
{"sk_runtimeeffect_get_uniform_name", sk_runtimeeffect_get_uniform_name}, // SkiaSharp
{"sk_runtimeeffect_get_uniform_size", sk_runtimeeffect_get_uniform_size}, // SkiaSharp
{"sk_runtimeeffect_get_uniforms_count", sk_runtimeeffect_get_uniforms_count}, // SkiaSharp
{"sk_runtimeeffect_make", sk_runtimeeffect_make}, // SkiaSharp
{"sk_runtimeeffect_make_color_filter", sk_runtimeeffect_make_color_filter}, // SkiaSharp
{"sk_runtimeeffect_make_shader", sk_runtimeeffect_make_shader}, // SkiaSharp
{"sk_runtimeeffect_uniform_get_offset", sk_runtimeeffect_uniform_get_offset}, // SkiaSharp
{"sk_runtimeeffect_uniform_get_size_in_bytes", sk_runtimeeffect_uniform_get_size_in_bytes}, // SkiaSharp
{"sk_runtimeeffect_unref", sk_runtimeeffect_unref}, // SkiaSharp
{"sk_shader_new_blend", sk_shader_new_blend}, // SkiaSharp
{"sk_shader_new_color", sk_shader_new_color}, // SkiaSharp
{"sk_shader_new_color4f", sk_shader_new_color4f}, // SkiaSharp
{"sk_shader_new_empty", sk_shader_new_empty}, // SkiaSharp
{"sk_shader_new_lerp", sk_shader_new_lerp}, // SkiaSharp
{"sk_shader_new_linear_gradient", sk_shader_new_linear_gradient}, // SkiaSharp
{"sk_shader_new_linear_gradient_color4f", sk_shader_new_linear_gradient_color4f}, // SkiaSharp
{"sk_shader_new_perlin_noise_fractal_noise", sk_shader_new_perlin_noise_fractal_noise}, // SkiaSharp
{"sk_shader_new_perlin_noise_improved_noise", sk_shader_new_perlin_noise_improved_noise}, // SkiaSharp
{"sk_shader_new_perlin_noise_turbulence", sk_shader_new_perlin_noise_turbulence}, // SkiaSharp
{"sk_shader_new_radial_gradient", sk_shader_new_radial_gradient}, // SkiaSharp
{"sk_shader_new_radial_gradient_color4f", sk_shader_new_radial_gradient_color4f}, // SkiaSharp
{"sk_shader_new_sweep_gradient", sk_shader_new_sweep_gradient}, // SkiaSharp
{"sk_shader_new_sweep_gradient_color4f", sk_shader_new_sweep_gradient_color4f}, // SkiaSharp
{"sk_shader_new_two_point_conical_gradient", sk_shader_new_two_point_conical_gradient}, // SkiaSharp
{"sk_shader_new_two_point_conical_gradient_color4f", sk_shader_new_two_point_conical_gradient_color4f}, // SkiaSharp
{"sk_shader_ref", sk_shader_ref}, // SkiaSharp
{"sk_shader_unref", sk_shader_unref}, // SkiaSharp
{"sk_shader_with_color_filter", sk_shader_with_color_filter}, // SkiaSharp
{"sk_shader_with_local_matrix", sk_shader_with_local_matrix}, // SkiaSharp
{"sk_stream_asset_destroy", sk_stream_asset_destroy}, // SkiaSharp
{"sk_stream_destroy", sk_stream_destroy}, // SkiaSharp
{"sk_stream_duplicate", sk_stream_duplicate}, // SkiaSharp
{"sk_stream_fork", sk_stream_fork}, // SkiaSharp
{"sk_stream_get_length", sk_stream_get_length}, // SkiaSharp
{"sk_stream_get_memory_base", sk_stream_get_memory_base}, // SkiaSharp
{"sk_stream_get_position", sk_stream_get_position}, // SkiaSharp
{"sk_stream_has_length", sk_stream_has_length}, // SkiaSharp
{"sk_stream_has_position", sk_stream_has_position}, // SkiaSharp
{"sk_stream_is_at_end", sk_stream_is_at_end}, // SkiaSharp
{"sk_stream_move", sk_stream_move}, // SkiaSharp
{"sk_stream_peek", sk_stream_peek}, // SkiaSharp
{"sk_stream_read", sk_stream_read}, // SkiaSharp
{"sk_stream_read_bool", sk_stream_read_bool}, // SkiaSharp
{"sk_stream_read_s16", sk_stream_read_s16}, // SkiaSharp
{"sk_stream_read_s32", sk_stream_read_s32}, // SkiaSharp
{"sk_stream_read_s8", sk_stream_read_s8}, // SkiaSharp
{"sk_stream_read_u16", sk_stream_read_u16}, // SkiaSharp
{"sk_stream_read_u32", sk_stream_read_u32}, // SkiaSharp
{"sk_stream_read_u8", sk_stream_read_u8}, // SkiaSharp
{"sk_stream_rewind", sk_stream_rewind}, // SkiaSharp
{"sk_stream_seek", sk_stream_seek}, // SkiaSharp
{"sk_stream_skip", sk_stream_skip}, // SkiaSharp
{"sk_string_destructor", sk_string_destructor}, // SkiaSharp
{"sk_string_get_c_str", sk_string_get_c_str}, // SkiaSharp
{"sk_string_get_size", sk_string_get_size}, // SkiaSharp
{"sk_string_new_empty", sk_string_new_empty}, // SkiaSharp
{"sk_string_new_with_copy", sk_string_new_with_copy}, // SkiaSharp
{"sk_surface_draw", sk_surface_draw}, // SkiaSharp
{"sk_surface_flush", sk_surface_flush}, // SkiaSharp
{"sk_surface_flush_and_submit", sk_surface_flush_and_submit}, // SkiaSharp
{"sk_surface_get_canvas", sk_surface_get_canvas}, // SkiaSharp
{"sk_surface_get_props", sk_surface_get_props}, // SkiaSharp
{"sk_surface_get_recording_context", sk_surface_get_recording_context}, // SkiaSharp
{"sk_surface_new_backend_render_target", sk_surface_new_backend_render_target}, // SkiaSharp
{"sk_surface_new_backend_texture", sk_surface_new_backend_texture}, // SkiaSharp
{"sk_surface_new_image_snapshot", sk_surface_new_image_snapshot}, // SkiaSharp
{"sk_surface_new_image_snapshot_with_crop", sk_surface_new_image_snapshot_with_crop}, // SkiaSharp
{"sk_surface_new_metal_layer", sk_surface_new_metal_layer}, // SkiaSharp
{"sk_surface_new_metal_view", sk_surface_new_metal_view}, // SkiaSharp
{"sk_surface_new_null", sk_surface_new_null}, // SkiaSharp
{"sk_surface_new_raster", sk_surface_new_raster}, // SkiaSharp
{"sk_surface_new_raster_direct", sk_surface_new_raster_direct}, // SkiaSharp
{"sk_surface_new_render_target", sk_surface_new_render_target}, // SkiaSharp
{"sk_surface_peek_pixels", sk_surface_peek_pixels}, // SkiaSharp
{"sk_surface_read_pixels", sk_surface_read_pixels}, // SkiaSharp
{"sk_surface_unref", sk_surface_unref}, // SkiaSharp
{"sk_surfaceprops_delete", sk_surfaceprops_delete}, // SkiaSharp
{"sk_surfaceprops_get_flags", sk_surfaceprops_get_flags}, // SkiaSharp
{"sk_surfaceprops_get_pixel_geometry", sk_surfaceprops_get_pixel_geometry}, // SkiaSharp
{"sk_surfaceprops_new", sk_surfaceprops_new}, // SkiaSharp
{"sk_svgcanvas_create_with_stream", sk_svgcanvas_create_with_stream}, // SkiaSharp
{"sk_svgcanvas_create_with_writer", sk_svgcanvas_create_with_writer}, // SkiaSharp
{"sk_swizzle_swap_rb", sk_swizzle_swap_rb}, // SkiaSharp
{"sk_text_utils_get_path", sk_text_utils_get_path}, // SkiaSharp
{"sk_text_utils_get_pos_path", sk_text_utils_get_pos_path}, // SkiaSharp
{"sk_textblob_builder_alloc_run", sk_textblob_builder_alloc_run}, // SkiaSharp
{"sk_textblob_builder_alloc_run_pos", sk_textblob_builder_alloc_run_pos}, // SkiaSharp
{"sk_textblob_builder_alloc_run_pos_h", sk_textblob_builder_alloc_run_pos_h}, // SkiaSharp
{"sk_textblob_builder_alloc_run_rsxform", sk_textblob_builder_alloc_run_rsxform}, // SkiaSharp
{"sk_textblob_builder_alloc_run_text", sk_textblob_builder_alloc_run_text}, // SkiaSharp
{"sk_textblob_builder_alloc_run_text_pos", sk_textblob_builder_alloc_run_text_pos}, // SkiaSharp
{"sk_textblob_builder_alloc_run_text_pos_h", sk_textblob_builder_alloc_run_text_pos_h}, // SkiaSharp
{"sk_textblob_builder_delete", sk_textblob_builder_delete}, // SkiaSharp
{"sk_textblob_builder_make", sk_textblob_builder_make}, // SkiaSharp
{"sk_textblob_builder_new", sk_textblob_builder_new}, // SkiaSharp
{"sk_textblob_get_bounds", sk_textblob_get_bounds}, // SkiaSharp
{"sk_textblob_get_intercepts", sk_textblob_get_intercepts}, // SkiaSharp
{"sk_textblob_get_unique_id", sk_textblob_get_unique_id}, // SkiaSharp
{"sk_textblob_ref", sk_textblob_ref}, // SkiaSharp
{"sk_textblob_unref", sk_textblob_unref}, // SkiaSharp
{"sk_typeface_copy_table_data", sk_typeface_copy_table_data}, // SkiaSharp
{"sk_typeface_count_glyphs", sk_typeface_count_glyphs}, // SkiaSharp
{"sk_typeface_count_tables", sk_typeface_count_tables}, // SkiaSharp
{"sk_typeface_create_default", sk_typeface_create_default}, // SkiaSharp
{"sk_typeface_create_from_data", sk_typeface_create_from_data}, // SkiaSharp
{"sk_typeface_create_from_file", sk_typeface_create_from_file}, // SkiaSharp
{"sk_typeface_create_from_name", sk_typeface_create_from_name}, // SkiaSharp
{"sk_typeface_create_from_stream", sk_typeface_create_from_stream}, // SkiaSharp
{"sk_typeface_get_family_name", sk_typeface_get_family_name}, // SkiaSharp
{"sk_typeface_get_font_slant", sk_typeface_get_font_slant}, // SkiaSharp
{"sk_typeface_get_font_weight", sk_typeface_get_font_weight}, // SkiaSharp
{"sk_typeface_get_font_width", sk_typeface_get_font_width}, // SkiaSharp
{"sk_typeface_get_fontstyle", sk_typeface_get_fontstyle}, // SkiaSharp
{"sk_typeface_get_kerning_pair_adjustments", sk_typeface_get_kerning_pair_adjustments}, // SkiaSharp
{"sk_typeface_get_table_data", sk_typeface_get_table_data}, // SkiaSharp
{"sk_typeface_get_table_size", sk_typeface_get_table_size}, // SkiaSharp
{"sk_typeface_get_table_tags", sk_typeface_get_table_tags}, // SkiaSharp
{"sk_typeface_get_units_per_em", sk_typeface_get_units_per_em}, // SkiaSharp
{"sk_typeface_is_fixed_pitch", sk_typeface_is_fixed_pitch}, // SkiaSharp
{"sk_typeface_open_stream", sk_typeface_open_stream}, // SkiaSharp
{"sk_typeface_ref_default", sk_typeface_ref_default}, // SkiaSharp
{"sk_typeface_unichar_to_glyph", sk_typeface_unichar_to_glyph}, // SkiaSharp
{"sk_typeface_unichars_to_glyphs", sk_typeface_unichars_to_glyphs}, // SkiaSharp
{"sk_typeface_unref", sk_typeface_unref}, // SkiaSharp
{"sk_version_get_increment", sk_version_get_increment}, // SkiaSharp
{"sk_version_get_milestone", sk_version_get_milestone}, // SkiaSharp
{"sk_version_get_string", sk_version_get_string}, // SkiaSharp
{"sk_vertices_make_copy", sk_vertices_make_copy}, // SkiaSharp
{"sk_vertices_ref", sk_vertices_ref}, // SkiaSharp
{"sk_vertices_unref", sk_vertices_unref}, // SkiaSharp
{"sk_webpencoder_encode", sk_webpencoder_encode}, // SkiaSharp
{"sk_wstream_bytes_written", sk_wstream_bytes_written}, // SkiaSharp
{"sk_wstream_flush", sk_wstream_flush}, // SkiaSharp
{"sk_wstream_get_size_of_packed_uint", sk_wstream_get_size_of_packed_uint}, // SkiaSharp
{"sk_wstream_newline", sk_wstream_newline}, // SkiaSharp
{"sk_wstream_write", sk_wstream_write}, // SkiaSharp
{"sk_wstream_write_16", sk_wstream_write_16}, // SkiaSharp
{"sk_wstream_write_32", sk_wstream_write_32}, // SkiaSharp
{"sk_wstream_write_8", sk_wstream_write_8}, // SkiaSharp
{"sk_wstream_write_bigdec_as_text", sk_wstream_write_bigdec_as_text}, // SkiaSharp
{"sk_wstream_write_bool", sk_wstream_write_bool}, // SkiaSharp
{"sk_wstream_write_dec_as_text", sk_wstream_write_dec_as_text}, // SkiaSharp
{"sk_wstream_write_hex_as_text", sk_wstream_write_hex_as_text}, // SkiaSharp
{"sk_wstream_write_packed_uint", sk_wstream_write_packed_uint}, // SkiaSharp
{"sk_wstream_write_scalar", sk_wstream_write_scalar}, // SkiaSharp
{"sk_wstream_write_scalar_as_text", sk_wstream_write_scalar_as_text}, // SkiaSharp
{"sk_wstream_write_stream", sk_wstream_write_stream}, // SkiaSharp
{"sk_wstream_write_text", sk_wstream_write_text}, // SkiaSharp
{"sk_xmlstreamwriter_delete", sk_xmlstreamwriter_delete}, // SkiaSharp
{"sk_xmlstreamwriter_new", sk_xmlstreamwriter_new}, // SkiaSharp
{NULL, NULL}
};
static PinvokeImport libSystem_Native_imports [] = {
{"SystemNative_Access", SystemNative_Access}, // System.Private.CoreLib
{"SystemNative_AlignedAlloc", SystemNative_AlignedAlloc}, // System.Private.CoreLib
{"SystemNative_AlignedFree", SystemNative_AlignedFree}, // System.Private.CoreLib
{"SystemNative_AlignedRealloc", SystemNative_AlignedRealloc}, // System.Private.CoreLib
{"SystemNative_Calloc", SystemNative_Calloc}, // System.Private.CoreLib
{"SystemNative_CanGetHiddenFlag", SystemNative_CanGetHiddenFlag}, // System.Private.CoreLib
{"SystemNative_ChDir", SystemNative_ChDir}, // System.Private.CoreLib
{"SystemNative_ChMod", SystemNative_ChMod}, // System.Private.CoreLib
{"SystemNative_Close", SystemNative_Close}, // System.Private.CoreLib
{"SystemNative_CloseDir", SystemNative_CloseDir}, // System.Private.CoreLib
{"SystemNative_ConvertErrorPalToPlatform", SystemNative_ConvertErrorPalToPlatform}, // System.Console, System.IO.Compression.ZipFile, System.IO.MemoryMappedFiles, System.Net.Primitives, System.Private.CoreLib
{"SystemNative_ConvertErrorPlatformToPal", SystemNative_ConvertErrorPlatformToPal}, // System.Console, System.IO.Compression.ZipFile, System.IO.MemoryMappedFiles, System.Net.Primitives, System.Private.CoreLib
{"SystemNative_CopyFile", SystemNative_CopyFile}, // System.Private.CoreLib
{"SystemNative_Dup", SystemNative_Dup}, // System.Console
{"SystemNative_FAllocate", SystemNative_FAllocate}, // System.Private.CoreLib
{"SystemNative_FChflags", SystemNative_FChflags}, // System.Private.CoreLib
{"SystemNative_FChMod", SystemNative_FChMod}, // System.Private.CoreLib
{"SystemNative_FcntlSetFD", SystemNative_FcntlSetFD}, // System.IO.MemoryMappedFiles
{"SystemNative_FLock", SystemNative_FLock}, // System.Private.CoreLib
{"SystemNative_Free", SystemNative_Free}, // System.Private.CoreLib
{"SystemNative_FreeEnviron", SystemNative_FreeEnviron}, // System.Private.CoreLib
{"SystemNative_FStat", SystemNative_FStat}, // System.IO.Compression.ZipFile, System.IO.MemoryMappedFiles, System.Private.CoreLib
{"SystemNative_FSync", SystemNative_FSync}, // System.Private.CoreLib
{"SystemNative_FTruncate", SystemNative_FTruncate}, // System.IO.MemoryMappedFiles, System.Private.CoreLib
{"SystemNative_FUTimens", SystemNative_FUTimens}, // System.Private.CoreLib
{"SystemNative_GetAddressFamily", SystemNative_GetAddressFamily}, // System.Net.Primitives
{"SystemNative_GetCpuUtilization", SystemNative_GetCpuUtilization}, // System.Private.CoreLib
{"SystemNative_GetCryptographicallySecureRandomBytes", SystemNative_GetCryptographicallySecureRandomBytes}, // System.Private.CoreLib, System.Security.Cryptography
{"SystemNative_GetCwd", SystemNative_GetCwd}, // System.Private.CoreLib
{"SystemNative_GetDefaultSearchOrderPseudoHandle", SystemNative_GetDefaultSearchOrderPseudoHandle}, // System.Private.CoreLib
{"SystemNative_GetEnv", SystemNative_GetEnv}, // System.Private.CoreLib
{"SystemNative_GetEnviron", SystemNative_GetEnviron}, // System.Private.CoreLib
{"SystemNative_GetErrNo", SystemNative_GetErrNo}, // System.Private.CoreLib
{"SystemNative_GetFileSystemType", SystemNative_GetFileSystemType}, // System.Private.CoreLib
{"SystemNative_GetIPSocketAddressSizes", SystemNative_GetIPSocketAddressSizes}, // System.Net.Primitives
{"SystemNative_GetIPv4Address", SystemNative_GetIPv4Address}, // System.Net.Primitives
{"SystemNative_GetIPv6Address", SystemNative_GetIPv6Address}, // System.Net.Primitives
{"SystemNative_GetNonCryptographicallySecureRandomBytes", SystemNative_GetNonCryptographicallySecureRandomBytes}, // System.Private.CoreLib
{"SystemNative_GetPort", SystemNative_GetPort}, // System.Net.Primitives
{"SystemNative_GetReadDirRBufferSize", SystemNative_GetReadDirRBufferSize}, // System.Private.CoreLib
{"SystemNative_GetSystemTimeAsTicks", SystemNative_GetSystemTimeAsTicks}, // System.Private.CoreLib
{"SystemNative_GetTimestamp", SystemNative_GetTimestamp}, // System.Private.CoreLib
{"SystemNative_LChflags", SystemNative_LChflags}, // System.Private.CoreLib
{"SystemNative_LChflagsCanSetHiddenFlag", SystemNative_LChflagsCanSetHiddenFlag}, // System.Private.CoreLib
{"SystemNative_Link", SystemNative_Link}, // System.Private.CoreLib
{"SystemNative_LockFileRegion", SystemNative_LockFileRegion}, // System.Private.CoreLib
{"SystemNative_Log", SystemNative_Log}, // System.Private.CoreLib
{"SystemNative_LogError", SystemNative_LogError}, // System.Private.CoreLib
{"SystemNative_LowLevelMonitor_Acquire", SystemNative_LowLevelMonitor_Acquire}, // System.Private.CoreLib
{"SystemNative_LowLevelMonitor_Create", SystemNative_LowLevelMonitor_Create}, // System.Private.CoreLib
{"SystemNative_LowLevelMonitor_Destroy", SystemNative_LowLevelMonitor_Destroy}, // System.Private.CoreLib
{"SystemNative_LowLevelMonitor_Release", SystemNative_LowLevelMonitor_Release}, // System.Private.CoreLib
{"SystemNative_LowLevelMonitor_Signal_Release", SystemNative_LowLevelMonitor_Signal_Release}, // System.Private.CoreLib
{"SystemNative_LowLevelMonitor_TimedWait", SystemNative_LowLevelMonitor_TimedWait}, // System.Private.CoreLib
{"SystemNative_LowLevelMonitor_Wait", SystemNative_LowLevelMonitor_Wait}, // System.Private.CoreLib
{"SystemNative_LSeek", SystemNative_LSeek}, // System.Private.CoreLib
{"SystemNative_LStat", SystemNative_LStat}, // System.Private.CoreLib
{"SystemNative_MAdvise", SystemNative_MAdvise}, // System.IO.MemoryMappedFiles
{"SystemNative_Malloc", SystemNative_Malloc}, // System.Private.CoreLib
{"SystemNative_MkDir", SystemNative_MkDir}, // System.Private.CoreLib
{"SystemNative_MkdTemp", SystemNative_MkdTemp}, // System.Private.CoreLib
{"SystemNative_MksTemps", SystemNative_MksTemps}, // System.Private.CoreLib
{"SystemNative_MMap", SystemNative_MMap}, // System.IO.MemoryMappedFiles
{"SystemNative_MSync", SystemNative_MSync}, // System.IO.MemoryMappedFiles
{"SystemNative_MUnmap", SystemNative_MUnmap}, // System.IO.MemoryMappedFiles
{"SystemNative_Open", SystemNative_Open}, // System.Private.CoreLib
{"SystemNative_OpenDir", SystemNative_OpenDir}, // System.Private.CoreLib
{"SystemNative_PosixFAdvise", SystemNative_PosixFAdvise}, // System.Private.CoreLib
{"SystemNative_PRead", SystemNative_PRead}, // System.Private.CoreLib
{"SystemNative_PReadV", SystemNative_PReadV}, // System.Private.CoreLib
{"SystemNative_PWrite", SystemNative_PWrite}, // System.Private.CoreLib
{"SystemNative_PWriteV", SystemNative_PWriteV}, // System.Private.CoreLib
{"SystemNative_Read", SystemNative_Read}, // System.Private.CoreLib
{"SystemNative_ReadDirR", SystemNative_ReadDirR}, // System.Private.CoreLib
{"SystemNative_ReadLink", SystemNative_ReadLink}, // System.Private.CoreLib
{"SystemNative_Realloc", SystemNative_Realloc}, // System.Private.CoreLib
{"SystemNative_Rename", SystemNative_Rename}, // System.Private.CoreLib
{"SystemNative_RmDir", SystemNative_RmDir}, // System.Private.CoreLib
{"SystemNative_SetAddressFamily", SystemNative_SetAddressFamily}, // System.Net.Primitives
{"SystemNative_SetErrNo", SystemNative_SetErrNo}, // System.Private.CoreLib
{"SystemNative_SetIPv4Address", SystemNative_SetIPv4Address}, // System.Net.Primitives
{"SystemNative_SetIPv6Address", SystemNative_SetIPv6Address}, // System.Net.Primitives
{"SystemNative_SetPort", SystemNative_SetPort}, // System.Net.Primitives
{"SystemNative_ShmOpen", SystemNative_ShmOpen}, // System.IO.MemoryMappedFiles
{"SystemNative_ShmUnlink", SystemNative_ShmUnlink}, // System.IO.MemoryMappedFiles
{"SystemNative_Stat", SystemNative_Stat}, // System.Private.CoreLib
{"SystemNative_StrErrorR", SystemNative_StrErrorR}, // System.Console, System.IO.Compression.ZipFile, System.IO.MemoryMappedFiles, System.Net.Primitives, System.Private.CoreLib
{"SystemNative_SymLink", SystemNative_SymLink}, // System.Private.CoreLib
{"SystemNative_SysConf", SystemNative_SysConf}, // System.IO.MemoryMappedFiles, System.Private.CoreLib
{"SystemNative_SysLog", SystemNative_SysLog}, // System.Private.CoreLib
{"SystemNative_Unlink", SystemNative_Unlink}, // System.IO.MemoryMappedFiles, System.Private.CoreLib
{"SystemNative_UTimensat", SystemNative_UTimensat}, // System.Private.CoreLib
{"SystemNative_Write", SystemNative_Write}, // System.Console, System.Private.CoreLib
{NULL, NULL}
};
static PinvokeImport libSystem_IO_Compression_Native_imports [] = {
{"CompressionNative_Crc32", CompressionNative_Crc32}, // System.IO.Compression
{"CompressionNative_Deflate", CompressionNative_Deflate}, // System.IO.Compression, System.Net.WebSockets
{"CompressionNative_DeflateEnd", CompressionNative_DeflateEnd}, // System.IO.Compression, System.Net.WebSockets
{"CompressionNative_DeflateInit2_", CompressionNative_DeflateInit2_}, // System.IO.Compression, System.Net.WebSockets
{"CompressionNative_Inflate", CompressionNative_Inflate}, // System.IO.Compression, System.Net.WebSockets
{"CompressionNative_InflateEnd", CompressionNative_InflateEnd}, // System.IO.Compression, System.Net.WebSockets
{"CompressionNative_InflateInit2_", CompressionNative_InflateInit2_}, // System.IO.Compression, System.Net.WebSockets
{NULL, NULL}
};
static PinvokeImport libSystem_Globalization_Native_imports [] = {
{"GlobalizationNative_ChangeCase", GlobalizationNative_ChangeCase}, // System.Private.CoreLib
{"GlobalizationNative_ChangeCaseInvariant", GlobalizationNative_ChangeCaseInvariant}, // System.Private.CoreLib
{"GlobalizationNative_ChangeCaseTurkish", GlobalizationNative_ChangeCaseTurkish}, // System.Private.CoreLib
{"GlobalizationNative_CloseSortHandle", GlobalizationNative_CloseSortHandle}, // System.Private.CoreLib
{"GlobalizationNative_CompareString", GlobalizationNative_CompareString}, // System.Private.CoreLib
{"GlobalizationNative_EndsWith", GlobalizationNative_EndsWith}, // System.Private.CoreLib
{"GlobalizationNative_EnumCalendarInfo", GlobalizationNative_EnumCalendarInfo}, // System.Private.CoreLib
{"GlobalizationNative_GetCalendarInfo", GlobalizationNative_GetCalendarInfo}, // System.Private.CoreLib
{"GlobalizationNative_GetCalendars", GlobalizationNative_GetCalendars}, // System.Private.CoreLib
{"GlobalizationNative_GetDefaultLocaleName", GlobalizationNative_GetDefaultLocaleName}, // System.Private.CoreLib
{"GlobalizationNative_GetICUVersion", GlobalizationNative_GetICUVersion}, // System.Private.CoreLib
{"GlobalizationNative_GetJapaneseEraStartDate", GlobalizationNative_GetJapaneseEraStartDate}, // System.Private.CoreLib
{"GlobalizationNative_GetLatestJapaneseEra", GlobalizationNative_GetLatestJapaneseEra}, // System.Private.CoreLib
{"GlobalizationNative_GetLocaleInfoGroupingSizes", GlobalizationNative_GetLocaleInfoGroupingSizes}, // System.Private.CoreLib
{"GlobalizationNative_GetLocaleInfoInt", GlobalizationNative_GetLocaleInfoInt}, // System.Private.CoreLib
{"GlobalizationNative_GetLocaleInfoString", GlobalizationNative_GetLocaleInfoString}, // System.Private.CoreLib
{"GlobalizationNative_GetLocaleName", GlobalizationNative_GetLocaleName}, // System.Private.CoreLib
{"GlobalizationNative_GetLocales", GlobalizationNative_GetLocales}, // System.Private.CoreLib
{"GlobalizationNative_GetLocaleTimeFormat", GlobalizationNative_GetLocaleTimeFormat}, // System.Private.CoreLib
{"GlobalizationNative_GetSortHandle", GlobalizationNative_GetSortHandle}, // System.Private.CoreLib
{"GlobalizationNative_GetSortKey", GlobalizationNative_GetSortKey}, // System.Private.CoreLib
{"GlobalizationNative_GetSortVersion", GlobalizationNative_GetSortVersion}, // System.Private.CoreLib
{"GlobalizationNative_IndexOf", GlobalizationNative_IndexOf}, // System.Private.CoreLib
{"GlobalizationNative_InitICUFunctions", GlobalizationNative_InitICUFunctions}, // System.Private.CoreLib
{"GlobalizationNative_InitOrdinalCasingPage", GlobalizationNative_InitOrdinalCasingPage}, // System.Private.CoreLib
{"GlobalizationNative_IsNormalized", GlobalizationNative_IsNormalized}, // System.Private.CoreLib
{"GlobalizationNative_IsPredefinedLocale", GlobalizationNative_IsPredefinedLocale}, // System.Private.CoreLib
{"GlobalizationNative_LastIndexOf", GlobalizationNative_LastIndexOf}, // System.Private.CoreLib
{"GlobalizationNative_LoadICU", GlobalizationNative_LoadICU}, // System.Private.CoreLib
{"GlobalizationNative_NormalizeString", GlobalizationNative_NormalizeString}, // System.Private.CoreLib
{"GlobalizationNative_StartsWith", GlobalizationNative_StartsWith}, // System.Private.CoreLib
{"GlobalizationNative_ToAscii", GlobalizationNative_ToAscii}, // System.Private.CoreLib
{"GlobalizationNative_ToUnicode", GlobalizationNative_ToUnicode}, // System.Private.CoreLib
{NULL, NULL}
};
static void *pinvoke_tables[] = { libSkiaSharp_imports,libSystem_Native_imports,libSystem_IO_Compression_Native_imports,libSystem_Globalization_Native_imports,};
static char *pinvoke_names[] = { "libSkiaSharp","libSystem.Native","libSystem.IO.Compression.Native","libSystem.Globalization.Native",};
InterpFtnDesc wasm_native_to_interp_ftndescs[35];
typedef void  (*WasmInterpEntrySig_0) (int*,int*,int*);
void wasm_native_to_interp_SkiaSharp_DelegateProxies_SKBitmapReleaseDelegateProxyImplementation (int arg0,int arg1) { 
((WasmInterpEntrySig_0)wasm_native_to_interp_ftndescs [0].func) (&arg0, &arg1, wasm_native_to_interp_ftndescs [0].arg);
}
typedef void  (*WasmInterpEntrySig_1) (int*,int*,int*);
void wasm_native_to_interp_SkiaSharp_DelegateProxies_SKDataReleaseDelegateProxyImplementation (int arg0,int arg1) { 
((WasmInterpEntrySig_1)wasm_native_to_interp_ftndescs [1].func) (&arg0, &arg1, wasm_native_to_interp_ftndescs [1].arg);
}
typedef void  (*WasmInterpEntrySig_2) (int*,int*,int*);
void wasm_native_to_interp_SkiaSharp_DelegateProxies_SKImageRasterReleaseDelegateProxyImplementationForCoTaskMem (int arg0,int arg1) { 
((WasmInterpEntrySig_2)wasm_native_to_interp_ftndescs [2].func) (&arg0, &arg1, wasm_native_to_interp_ftndescs [2].arg);
}
typedef void  (*WasmInterpEntrySig_3) (int*,int*,int*);
void wasm_native_to_interp_SkiaSharp_DelegateProxies_SKImageRasterReleaseDelegateProxyImplementation (int arg0,int arg1) { 
((WasmInterpEntrySig_3)wasm_native_to_interp_ftndescs [3].func) (&arg0, &arg1, wasm_native_to_interp_ftndescs [3].arg);
}
typedef void  (*WasmInterpEntrySig_4) (int*,int*);
void wasm_native_to_interp_SkiaSharp_DelegateProxies_SKImageTextureReleaseDelegateProxyImplementation (int arg0) { 
((WasmInterpEntrySig_4)wasm_native_to_interp_ftndescs [4].func) (&arg0, wasm_native_to_interp_ftndescs [4].arg);
}
typedef void  (*WasmInterpEntrySig_5) (int*,int*,int*);
void wasm_native_to_interp_SkiaSharp_DelegateProxies_SKSurfaceReleaseDelegateProxyImplementation (int arg0,int arg1) { 
((WasmInterpEntrySig_5)wasm_native_to_interp_ftndescs [5].func) (&arg0, &arg1, wasm_native_to_interp_ftndescs [5].arg);
}
typedef void  (*WasmInterpEntrySig_6) (int*,int*,int*,int*);
int wasm_native_to_interp_SkiaSharp_DelegateProxies_GRGlGetProcDelegateProxyImplementation (int arg0,int arg1) { 
int res;
((WasmInterpEntrySig_6)wasm_native_to_interp_ftndescs [6].func) (&res, &arg0, &arg1, wasm_native_to_interp_ftndescs [6].arg);
return res;
}
typedef void  (*WasmInterpEntrySig_7) (int*,int*,int*,int*,int*,int*);
int wasm_native_to_interp_SkiaSharp_DelegateProxies_GRVkGetProcDelegateProxyImplementation (int arg0,int arg1,int arg2,int arg3) { 
int res;
((WasmInterpEntrySig_7)wasm_native_to_interp_ftndescs [7].func) (&res, &arg0, &arg1, &arg2, &arg3, wasm_native_to_interp_ftndescs [7].arg);
return res;
}
typedef void  (*WasmInterpEntrySig_8) (int*,int*,int*,int*);
void wasm_native_to_interp_SkiaSharp_DelegateProxies_SKGlyphPathDelegateProxyImplementation (int arg0,int arg1,int arg2) { 
((WasmInterpEntrySig_8)wasm_native_to_interp_ftndescs [8].func) (&arg0, &arg1, &arg2, wasm_native_to_interp_ftndescs [8].arg);
}
typedef void  (*WasmInterpEntrySig_9) (int*,int*,int*,int*,int*,int*);
int wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_ReadInternal (int arg0,int arg1,int arg2,int arg3) { 
int res;
((WasmInterpEntrySig_9)wasm_native_to_interp_ftndescs [9].func) (&res, &arg0, &arg1, &arg2, &arg3, wasm_native_to_interp_ftndescs [9].arg);
return res;
}
typedef void  (*WasmInterpEntrySig_10) (int*,int*,int*,int*,int*,int*);
int wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_PeekInternal (int arg0,int arg1,int arg2,int arg3) { 
int res;
((WasmInterpEntrySig_10)wasm_native_to_interp_ftndescs [10].func) (&res, &arg0, &arg1, &arg2, &arg3, wasm_native_to_interp_ftndescs [10].arg);
return res;
}
typedef void  (*WasmInterpEntrySig_11) (int*,int*,int*,int*);
int wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_IsAtEndInternal (int arg0,int arg1) { 
int res;
((WasmInterpEntrySig_11)wasm_native_to_interp_ftndescs [11].func) (&res, &arg0, &arg1, wasm_native_to_interp_ftndescs [11].arg);
return res;
}
typedef void  (*WasmInterpEntrySig_12) (int*,int*,int*,int*);
int wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_HasPositionInternal (int arg0,int arg1) { 
int res;
((WasmInterpEntrySig_12)wasm_native_to_interp_ftndescs [12].func) (&res, &arg0, &arg1, wasm_native_to_interp_ftndescs [12].arg);
return res;
}
typedef void  (*WasmInterpEntrySig_13) (int*,int*,int*,int*);
int wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_HasLengthInternal (int arg0,int arg1) { 
int res;
((WasmInterpEntrySig_13)wasm_native_to_interp_ftndescs [13].func) (&res, &arg0, &arg1, wasm_native_to_interp_ftndescs [13].arg);
return res;
}
typedef void  (*WasmInterpEntrySig_14) (int*,int*,int*,int*);
int wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_RewindInternal (int arg0,int arg1) { 
int res;
((WasmInterpEntrySig_14)wasm_native_to_interp_ftndescs [14].func) (&res, &arg0, &arg1, wasm_native_to_interp_ftndescs [14].arg);
return res;
}
typedef void  (*WasmInterpEntrySig_15) (int*,int*,int*,int*);
int wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_GetPositionInternal (int arg0,int arg1) { 
int res;
((WasmInterpEntrySig_15)wasm_native_to_interp_ftndescs [15].func) (&res, &arg0, &arg1, wasm_native_to_interp_ftndescs [15].arg);
return res;
}
typedef void  (*WasmInterpEntrySig_16) (int*,int*,int*,int*,int*);
int wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_SeekInternal (int arg0,int arg1,int arg2) { 
int res;
((WasmInterpEntrySig_16)wasm_native_to_interp_ftndescs [16].func) (&res, &arg0, &arg1, &arg2, wasm_native_to_interp_ftndescs [16].arg);
return res;
}
typedef void  (*WasmInterpEntrySig_17) (int*,int*,int*,int*,int*);
int wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_MoveInternal (int arg0,int arg1,int arg2) { 
int res;
((WasmInterpEntrySig_17)wasm_native_to_interp_ftndescs [17].func) (&res, &arg0, &arg1, &arg2, wasm_native_to_interp_ftndescs [17].arg);
return res;
}
typedef void  (*WasmInterpEntrySig_18) (int*,int*,int*,int*);
int wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_GetLengthInternal (int arg0,int arg1) { 
int res;
((WasmInterpEntrySig_18)wasm_native_to_interp_ftndescs [18].func) (&res, &arg0, &arg1, wasm_native_to_interp_ftndescs [18].arg);
return res;
}
typedef void  (*WasmInterpEntrySig_19) (int*,int*,int*,int*);
int wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_DuplicateInternal (int arg0,int arg1) { 
int res;
((WasmInterpEntrySig_19)wasm_native_to_interp_ftndescs [19].func) (&res, &arg0, &arg1, wasm_native_to_interp_ftndescs [19].arg);
return res;
}
typedef void  (*WasmInterpEntrySig_20) (int*,int*,int*,int*);
int wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_ForkInternal (int arg0,int arg1) { 
int res;
((WasmInterpEntrySig_20)wasm_native_to_interp_ftndescs [20].func) (&res, &arg0, &arg1, wasm_native_to_interp_ftndescs [20].arg);
return res;
}
typedef void  (*WasmInterpEntrySig_21) (int*,int*,int*);
void wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_DestroyInternal (int arg0,int arg1) { 
((WasmInterpEntrySig_21)wasm_native_to_interp_ftndescs [21].func) (&arg0, &arg1, wasm_native_to_interp_ftndescs [21].arg);
}
typedef void  (*WasmInterpEntrySig_22) (int*,int*,int*,int*,int*,int*);
int wasm_native_to_interp_SkiaSharp_SKAbstractManagedWStream_WriteInternal (int arg0,int arg1,int arg2,int arg3) { 
int res;
((WasmInterpEntrySig_22)wasm_native_to_interp_ftndescs [22].func) (&res, &arg0, &arg1, &arg2, &arg3, wasm_native_to_interp_ftndescs [22].arg);
return res;
}
typedef void  (*WasmInterpEntrySig_23) (int*,int*,int*);
void wasm_native_to_interp_SkiaSharp_SKAbstractManagedWStream_FlushInternal (int arg0,int arg1) { 
((WasmInterpEntrySig_23)wasm_native_to_interp_ftndescs [23].func) (&arg0, &arg1, wasm_native_to_interp_ftndescs [23].arg);
}
typedef void  (*WasmInterpEntrySig_24) (int*,int*,int*,int*);
int wasm_native_to_interp_SkiaSharp_SKAbstractManagedWStream_BytesWrittenInternal (int arg0,int arg1) { 
int res;
((WasmInterpEntrySig_24)wasm_native_to_interp_ftndescs [24].func) (&res, &arg0, &arg1, wasm_native_to_interp_ftndescs [24].arg);
return res;
}
typedef void  (*WasmInterpEntrySig_25) (int*,int*,int*);
void wasm_native_to_interp_SkiaSharp_SKAbstractManagedWStream_DestroyInternal (int arg0,int arg1) { 
((WasmInterpEntrySig_25)wasm_native_to_interp_ftndescs [25].func) (&arg0, &arg1, wasm_native_to_interp_ftndescs [25].arg);
}
typedef void  (*WasmInterpEntrySig_26) (int*,int*,int*,int*);
void wasm_native_to_interp_SkiaSharp_SKDrawable_DrawInternal (int arg0,int arg1,int arg2) { 
((WasmInterpEntrySig_26)wasm_native_to_interp_ftndescs [26].func) (&arg0, &arg1, &arg2, wasm_native_to_interp_ftndescs [26].arg);
}
typedef void  (*WasmInterpEntrySig_27) (int*,int*,int*,int*);
void wasm_native_to_interp_SkiaSharp_SKDrawable_GetBoundsInternal (int arg0,int arg1,int arg2) { 
((WasmInterpEntrySig_27)wasm_native_to_interp_ftndescs [27].func) (&arg0, &arg1, &arg2, wasm_native_to_interp_ftndescs [27].arg);
}
typedef void  (*WasmInterpEntrySig_28) (int*,int*,int*,int*);
int wasm_native_to_interp_SkiaSharp_SKDrawable_NewPictureSnapshotInternal (int arg0,int arg1) { 
int res;
((WasmInterpEntrySig_28)wasm_native_to_interp_ftndescs [28].func) (&res, &arg0, &arg1, wasm_native_to_interp_ftndescs [28].arg);
return res;
}
typedef void  (*WasmInterpEntrySig_29) (int*,int*,int*);
void wasm_native_to_interp_SkiaSharp_SKDrawable_DestroyInternal (int arg0,int arg1) { 
((WasmInterpEntrySig_29)wasm_native_to_interp_ftndescs [29].func) (&arg0, &arg1, wasm_native_to_interp_ftndescs [29].arg);
}
typedef void  (*WasmInterpEntrySig_30) (int*,int*,int*,int*,int*,int*,int*);
void wasm_native_to_interp_SkiaSharp_SKTraceMemoryDump_DumpNumericValueInternal (int arg0,int arg1,int arg2,int arg3,int arg4,uint64_t arg5) { 
((WasmInterpEntrySig_30)wasm_native_to_interp_ftndescs [30].func) (&arg0, &arg1, &arg2, &arg3, &arg4, &arg5, wasm_native_to_interp_ftndescs [30].arg);
}
typedef void  (*WasmInterpEntrySig_31) (int*,int*,int*,int*,int*,int*);
void wasm_native_to_interp_SkiaSharp_SKTraceMemoryDump_DumpStringValueInternal (int arg0,int arg1,int arg2,int arg3,int arg4) { 
((WasmInterpEntrySig_31)wasm_native_to_interp_ftndescs [31].func) (&arg0, &arg1, &arg2, &arg3, &arg4, wasm_native_to_interp_ftndescs [31].arg);
}
typedef void  (*WasmInterpEntrySig_32) (int*,int*,int*,int*,int*,int*,int*,int*);
int wasm_native_to_interp_System_Private_CoreLib_ComponentActivator_LoadAssemblyAndGetFunctionPointer (int arg0,int arg1,int arg2,int arg3,int arg4,int arg5) { 
int res;
((WasmInterpEntrySig_32)wasm_native_to_interp_ftndescs [32].func) (&res, &arg0, &arg1, &arg2, &arg3, &arg4, &arg5, wasm_native_to_interp_ftndescs [32].arg);
return res;
}
typedef void  (*WasmInterpEntrySig_33) (int*,int*,int*,int*,int*,int*,int*,int*);
int wasm_native_to_interp_System_Private_CoreLib_ComponentActivator_GetFunctionPointer (int arg0,int arg1,int arg2,int arg3,int arg4,int arg5) { 
int res;
((WasmInterpEntrySig_33)wasm_native_to_interp_ftndescs [33].func) (&res, &arg0, &arg1, &arg2, &arg3, &arg4, &arg5, wasm_native_to_interp_ftndescs [33].arg);
return res;
}
typedef void  (*WasmInterpEntrySig_34) (int*,int*,int*);
void wasm_native_to_interp_System_Private_CoreLib_CalendarData_EnumCalendarInfoCallback (int arg0,int arg1) { 
((WasmInterpEntrySig_34)wasm_native_to_interp_ftndescs [34].func) (&arg0, &arg1, wasm_native_to_interp_ftndescs [34].arg);
}
static void *wasm_native_to_interp_funcs[] = { wasm_native_to_interp_SkiaSharp_DelegateProxies_SKBitmapReleaseDelegateProxyImplementation,wasm_native_to_interp_SkiaSharp_DelegateProxies_SKDataReleaseDelegateProxyImplementation,wasm_native_to_interp_SkiaSharp_DelegateProxies_SKImageRasterReleaseDelegateProxyImplementationForCoTaskMem,wasm_native_to_interp_SkiaSharp_DelegateProxies_SKImageRasterReleaseDelegateProxyImplementation,wasm_native_to_interp_SkiaSharp_DelegateProxies_SKImageTextureReleaseDelegateProxyImplementation,wasm_native_to_interp_SkiaSharp_DelegateProxies_SKSurfaceReleaseDelegateProxyImplementation,wasm_native_to_interp_SkiaSharp_DelegateProxies_GRGlGetProcDelegateProxyImplementation,wasm_native_to_interp_SkiaSharp_DelegateProxies_GRVkGetProcDelegateProxyImplementation,wasm_native_to_interp_SkiaSharp_DelegateProxies_SKGlyphPathDelegateProxyImplementation,wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_ReadInternal,wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_PeekInternal,wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_IsAtEndInternal,wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_HasPositionInternal,wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_HasLengthInternal,wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_RewindInternal,wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_GetPositionInternal,wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_SeekInternal,wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_MoveInternal,wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_GetLengthInternal,wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_DuplicateInternal,wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_ForkInternal,wasm_native_to_interp_SkiaSharp_SKAbstractManagedStream_DestroyInternal,wasm_native_to_interp_SkiaSharp_SKAbstractManagedWStream_WriteInternal,wasm_native_to_interp_SkiaSharp_SKAbstractManagedWStream_FlushInternal,wasm_native_to_interp_SkiaSharp_SKAbstractManagedWStream_BytesWrittenInternal,wasm_native_to_interp_SkiaSharp_SKAbstractManagedWStream_DestroyInternal,wasm_native_to_interp_SkiaSharp_SKDrawable_DrawInternal,wasm_native_to_interp_SkiaSharp_SKDrawable_GetBoundsInternal,wasm_native_to_interp_SkiaSharp_SKDrawable_NewPictureSnapshotInternal,wasm_native_to_interp_SkiaSharp_SKDrawable_DestroyInternal,wasm_native_to_interp_SkiaSharp_SKTraceMemoryDump_DumpNumericValueInternal,wasm_native_to_interp_SkiaSharp_SKTraceMemoryDump_DumpStringValueInternal,wasm_native_to_interp_System_Private_CoreLib_ComponentActivator_LoadAssemblyAndGetFunctionPointer,wasm_native_to_interp_System_Private_CoreLib_ComponentActivator_GetFunctionPointer,wasm_native_to_interp_System_Private_CoreLib_CalendarData_EnumCalendarInfoCallback,};
static const char *wasm_native_to_interp_map[] = { "SkiaSharp_DelegateProxies_SKBitmapReleaseDelegateProxyImplementation",
"SkiaSharp_DelegateProxies_SKDataReleaseDelegateProxyImplementation",
"SkiaSharp_DelegateProxies_SKImageRasterReleaseDelegateProxyImplementationForCoTaskMem",
"SkiaSharp_DelegateProxies_SKImageRasterReleaseDelegateProxyImplementation",
"SkiaSharp_DelegateProxies_SKImageTextureReleaseDelegateProxyImplementation",
"SkiaSharp_DelegateProxies_SKSurfaceReleaseDelegateProxyImplementation",
"SkiaSharp_DelegateProxies_GRGlGetProcDelegateProxyImplementation",
"SkiaSharp_DelegateProxies_GRVkGetProcDelegateProxyImplementation",
"SkiaSharp_DelegateProxies_SKGlyphPathDelegateProxyImplementation",
"SkiaSharp_SKAbstractManagedStream_ReadInternal",
"SkiaSharp_SKAbstractManagedStream_PeekInternal",
"SkiaSharp_SKAbstractManagedStream_IsAtEndInternal",
"SkiaSharp_SKAbstractManagedStream_HasPositionInternal",
"SkiaSharp_SKAbstractManagedStream_HasLengthInternal",
"SkiaSharp_SKAbstractManagedStream_RewindInternal",
"SkiaSharp_SKAbstractManagedStream_GetPositionInternal",
"SkiaSharp_SKAbstractManagedStream_SeekInternal",
"SkiaSharp_SKAbstractManagedStream_MoveInternal",
"SkiaSharp_SKAbstractManagedStream_GetLengthInternal",
"SkiaSharp_SKAbstractManagedStream_DuplicateInternal",
"SkiaSharp_SKAbstractManagedStream_ForkInternal",
"SkiaSharp_SKAbstractManagedStream_DestroyInternal",
"SkiaSharp_SKAbstractManagedWStream_WriteInternal",
"SkiaSharp_SKAbstractManagedWStream_FlushInternal",
"SkiaSharp_SKAbstractManagedWStream_BytesWrittenInternal",
"SkiaSharp_SKAbstractManagedWStream_DestroyInternal",
"SkiaSharp_SKDrawable_DrawInternal",
"SkiaSharp_SKDrawable_GetBoundsInternal",
"SkiaSharp_SKDrawable_NewPictureSnapshotInternal",
"SkiaSharp_SKDrawable_DestroyInternal",
"SkiaSharp_SKTraceMemoryDump_DumpNumericValueInternal",
"SkiaSharp_SKTraceMemoryDump_DumpStringValueInternal",
"System_Private_CoreLib_ComponentActivator_LoadAssemblyAndGetFunctionPointer",
"System_Private_CoreLib_ComponentActivator_GetFunctionPointer",
"System_Private_CoreLib_CalendarData_EnumCalendarInfoCallback",
};
