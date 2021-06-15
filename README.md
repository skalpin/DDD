# DDD

## Overview

This document is to be used to capture the description of the project. Each
update is to be posted at the top, and dated.

## 6/14 - Business

I will be using my current project for my model domain, a generic HVAC Company,
AnyHVAC. I have been working with AnyHVAC for over a year. I have not
seen any "Domain" code, however there are several projects that share concepts
that may or may not turn into bounded contexts. I will first describe the 
business, and then walk through terms I think are important to the model.

### Proposal

AnyHVAC is in the business of designing and selling HVAC systems to industrial
companies. The process starts when a contractor sends out requests for 
proposals. A AnyHVAC sales engineer will then design a system. This design 
includes the devices, like air dampers, valves, and coils, and the controllers 
which are the computers for the system. The controllers read in sensor 
information, and determine if they need to take action.

The tasks a system performs is spelled out in paragraph form in a sequence 
of operation (SOO for short). This text tells the field technician when devices 
need to be activated. For example turn the supply fan on.

A bill of materials is created that has a short description of each part, and 
the estimated cost of each part.

The proposal is then printed as a document and submitted.

### Engineering

If AnyHVAC wins the project, the documents are sent to a AnyHVAC HVAC engineer. The 
engineer reviews the documents, and reviews the controller details. They can 
make changes to devices in the system to better fit the requirements. Details 
are added to the drawings to include how each device will connect to the 
controller and expansion modules. The engineer makes sure the Field Technician 
has enough information to connect each device to the controller and how each 
wire will be labeled.

### Field Technician

When all of the devices and parts have been delivered, a field technician 
comes on site and installs the system. They install all the devices, connect 
wires to the controller, and configure the controller. The controller needs to 
be programmed to tell it what to do with the various points that are connected. 
If the field technician connected, and programmed everything properly, they 
can test the system using the sequence of operations. 

### Configurator

The current systems at AnyHVAC allow for the engineering documents to be exported 
and imported into software called *Configurator*. Configurator creates the 
programs a field technician installs on a controller. If the controller in the 
document is a UC400 or a UC600, the Engineer can export the programs for the 
field technician so they do not have to program it manually.

### Rules

I haven't mentioned rules yet, but most systems are designed using them. AnyHVAC 
engineers fill out a form with dropdown boxes that describe the *features* of a 
system. Then the software determines which devices need to be included, what 
paragraphs of SOO text to include, which controller to include, and how the 
devices will connect to the controller.

### Point Names

Point names can be many things. A UC600 for instance has 8 analog outputs. They 
are labeled AO1 - AO8. It also has 8 points that can either be universal inputs 
or analog outputs, labeled UI1/AO9, UI2/AO10.

Sometimes point names are used to describe the *purpose* of a point. For example 
**supply fan** or **differential pressure switch**. 

### Cable Tag

Cable tags are used to label wires at the device and the controller. An example 
tag would be **1107**.

### Point Types

Points can either be

### Ubiquitous Language

Some important terms from the text above:

#### Controller

Determines when, and what to do with the HVAC system after it has been 
installed.

#### Controller Point

Place for device to connect

#### Device

Anything that connects to a controller. An Air Duct, is not a device. A damper 
with an attached actuator is a device. A damper itself is not a device.

#### Part

Air ducts, Air filters are parts of a system.

#### Sequence of operations

Text used to describe how a system should behave given specific inputs.

#### Submittal

Documents submitted to the building contractor.

#### Engineering Documents

Documents that the field technician uses to install and test the system.

#### Program

Tells the controller what to do with a particular point.