﻿Module structure_definition
    'define structure
    Public Structure job
        Dim job_id As Integer 'PK - Autogenerated
        <VBFixedString(16)> Dim job_username As String 'Automatically generated from PC name
        <VBFixedString(16)> Dim job_date_created As String 'Automatically generated
        <VBFixedString(26)> Dim job_name As String 'Textbox input
        Dim job_pinned As Boolean 'checkbox
        Dim job_count As Integer 'autogenerated
    End Structure
    Public Structure job_product
        Dim job_id As Integer 'FK - Automatically generated
        Dim product_id As Integer 'FK - Automatically generated
        Dim quantity As Integer 'Combobox
    End Structure
    Public Structure product
        Dim product_id As Integer 'PK 'Automatically generated
        <VBFixedString(45)> Dim product_desc As String 'Input via Texbox
        <VBFixedString(26)> Dim product_code As String 'Input Via Combo box
    End Structure
    Public Structure product_component
        Dim product_id As Integer 'FK 'Automatically generated
        Dim component_id As Integer 'FK 'Automatically generated
        Dim quantity As Integer ' Combo box
    End Structure
    Public Structure component
        Dim component_id As Integer 'PK 'Automatically generated
        <VBFixedString(45)> Dim component_desc As String 'Textbox Input
        <VBFixedString(26)> Dim component_code As String 'Textbox Input
    End Structure
    Public Structure component_location
        Dim component_id As Integer 'FK 'Automatically generated
        Dim location_id As Integer 'FK 'Automatically generated
        Dim stock_count As Integer 'Combo box
    End Structure
    Public Structure location
        Dim location_id As Integer 'PK 'Automatically generated
        <VBFixedString(26)> Dim location_desc As String 'TextBox Input
    End Structure
    Public Structure current_job
        Dim item_id As Integer 'PK 'Automatically generated
        Dim product_id As Integer 'FK
        Dim quantity As Integer 'Taken from combo box when selecting amount of product
    End Structure
    Public Structure conv_time
        Dim hours As Long
        Dim minutes As Long
        Dim seconds As Long
        Dim milliseconds As Long
    End Structure
    Public Structure user_settings
        Dim first_time As Boolean
        Dim display_help_recordeditor As Boolean
    End Structure
    Public Structure product_trend
        Dim ID As Integer
        Dim Quantity As Integer
        Dim dateOutput As DateTime
    End Structure
    Public Structure component_trend
        Dim ID As Integer
        Dim Quantity As Integer
        Dim dateOutput As DateTime
    End Structure
    Public Structure password
        Dim active As Boolean
        Dim encrypted As Boolean
        <VBFixedString(26)> Dim password As String
    End Structure
    'initialize instances
    Public current_settings As user_settings
    Public job_record As job
    Public location_record As location
    Public password_record As password
    Public component_record As component
    Public product_record As product
    Public product_component_record As product_component
    Public component_location_record As component_location
    Public current_job_record As current_job
    Public job_product_record As job_product
    Public product_trend_record As product_trend
    Public component_trend_record As component_trend
End Module