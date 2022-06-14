# Progression System
This is a free and open system to store progression during gameplay using scriptable objects.

## Description
The system is structures with the following elements

### Progression Container


### Progression Base
This is a base class for all the progression types.

**Variables:**
- name [String]

**Methods:**


### Progression Bool
This is a child class of Progression Base.

**Variables:**
- name (inherited)
- value [true/false]

**Methods:**
- Trigger (sets value to true)
- Reset (sets value to false)


### Progression Count
This is a base class for all the progression types.

**Variables:**
- name (inherited)
- value [int >= 0]

**Methods:**
- Increment (increases value by 1)
- Decrement (decreases value by 1)
- Reset (sets value to 0)


### Progression Time
This is a base class for all the progression types.

**Variables:**
- name (inherited)
- value [int >= 0]

**Methods:**
- Update (sets value to Time.time)
- ToString (returns time in +H:MM:SS format)
- Reset (sets value to 0)
