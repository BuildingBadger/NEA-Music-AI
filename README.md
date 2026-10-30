# NEA Music AI

An A-level Computer Science Non-Exam Assessment project exploring the use of artificial intelligence in music-related applications.


## Contents

- [Overview](#overview)
- [Objectives](#objectives)
- [Features](#features)
- [Technology](#technology)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Development](#development)
- [Testing](#testing)
- [Limitations and Future Improvements](#limitations-and-future-improvements)
- [Author](#author)

## Overview

NEA Music AI is a coursework project investigating how artificial intelligence can be applied to music. The system is designed to process musical data and produce an AI-assisted result, such as generating, classifying, recommending, or transforming music.

The project also documents the software development process, including requirements analysis, system design, implementation, testing, evaluation, and reflection.

## Objectives

- Explore the use of AI within a music-focused application.
- Design and implement a usable software solution.
- Process musical input in a structured and repeatable way.
- Evaluate the quality, accuracy, or usefulness of the system's output.
- Record design decisions and development progress as part of the NEA coursework.

## Features

- Video-game-Music-focused AI functionality.
- Input processing and validation.
- AI-assisted output generation or analysis.
- A user interface or command-line workflow for interacting with the system.
- Evaluation and testing of generated results.


## Technology

- **Language:** C# for the AI and the maths behind it, and Python for getting and editing the data
- **Interface:** .NET Framework.
- **Data:** vgmusic.com
- **Testing:** Backpropogation.

## Getting Started

### Prerequisites

Install the software required by the project before running it. A typical setup may require:

- Python 3.10 or later
- Git
- The dependencies listed in `requirements.txt`

### Installation

Clone the repository:

```bash
git clone https://github.com/BuildingBadger/NEA-Music-AI.git
cd NEA-Music-AI
```

Create and activate a virtual environment:

```bash
python -m venv .venv
```

On Windows:

```bash
.venv\Scripts\activate
```

On macOS or Linux:

```bash
source .venv/bin/activate
```

Install the project dependencies if a dependency file is provided:

```bash
pip install -r requirements.txt
```

## Usage

Add the project's actual entry-point command below. For example:

```bash
python main.py
```

If the project uses a graphical interface, web server, notebook, or separate training and inference scripts, document those commands here.

### Configuration

Document any required configuration, datasets, model files, or environment variables here. Do not commit private API keys or credentials to the repository.

Example:

```bash
# .env
MODEL_PATH=path/to/model
DATASET_PATH=path/to/dataset
```

## Project Structure

Update the descriptions to match the repository's actual files and folders.

```text
NEA-Music-AI/
├── data/              # Music data or sample input files
├── models/            # Saved or trained AI models
├── src/               # Main source code
├── tests/             # Automated or manual test resources
├── requirements.txt   # Python dependencies
└── README.md          # Project documentation
```

## Development

A typical development workflow is:

1. Review the requirements and success criteria.
2. Prepare the input data and configuration.
3. Implement or update the relevant system component.
4. Run the application and test representative inputs.
5. Record the results and update the project documentation.

## Testing

Test the system using valid, invalid, and edge-case inputs. Testing should cover:

- Input validation.
- Core AI or music-processing functionality.
- Output format and usability.
- Error handling.
- Performance and repeatability where relevant.

Add the project's test command here when available:

```bash
python -m pytest
```

## Limitations and Future Improvements

Potential areas for further development include:

- Improving the quality and consistency of generated or analysed music.
- Expanding the size and variety of the training or evaluation data.
- Adding more user controls and configuration options.
- Improving runtime performance.
- Providing clearer visual feedback about how the AI produces its output.
- Comparing multiple algorithms or model configurations.

## Author

Developed by **Ben Jordan** as part of an A-level Computer Science NEA project.
