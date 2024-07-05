import {FC, ReactElement, useRef, useEffect, useState} from 'react';
import {CreateNoteDto, Client, NoteLookupDTO} from '../api/api';
import { FormControl } from 'react-bootstrap';

const apiClient = new Client('https://localhost:44353')