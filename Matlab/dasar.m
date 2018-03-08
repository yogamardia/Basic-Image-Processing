function varargout = dasar(varargin)
% DASAR MATLAB code for dasar.fig
%      DASAR, by itself, creates a new DASAR or raises the existing
%      singleton*.
%
%      H = DASAR returns the handle to a new DASAR or the handle to
%      the existing singleton*.
%
%      DASAR('CALLBACK',hObject,eventData,handles,...) calls the local
%      function named CALLBACK in DASAR.M with the given input arguments.
%
%      DASAR('Property','Value',...) creates a new DASAR or raises the
%      existing singleton*.  Starting from the left, property value pairs are
%      applied to the GUI before dasar_OpeningFcn gets called.  An
%      unrecognized property name or invalid value makes property application
%      stop.  All inputs are passed to dasar_OpeningFcn via varargin.
%
%      *See GUI Options on GUIDE's Tools menu.  Choose "GUI allows only one
%      instance to run (singleton)".
%
% See also: GUIDE, GUIDATA, GUIHANDLES

% Edit the above text to modify the response to help dasar

% Last Modified by GUIDE v2.5 08-Mar-2018 20:27:23

% Begin initialization code - DO NOT EDIT
gui_Singleton = 1;
gui_State = struct('gui_Name',       mfilename, ...
                   'gui_Singleton',  gui_Singleton, ...
                   'gui_OpeningFcn', @dasar_OpeningFcn, ...
                   'gui_OutputFcn',  @dasar_OutputFcn, ...
                   'gui_LayoutFcn',  [] , ...
                   'gui_Callback',   []);
if nargin && ischar(varargin{1})
    gui_State.gui_Callback = str2func(varargin{1});
end

if nargout
    [varargout{1:nargout}] = gui_mainfcn(gui_State, varargin{:});
else
    gui_mainfcn(gui_State, varargin{:});
end
% End initialization code - DO NOT EDIT


% --- Executes just before dasar is made visible.
function dasar_OpeningFcn(hObject, eventdata, handles, varargin)
% This function has no output args, see OutputFcn.
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
% varargin   command line arguments to dasar (see VARARGIN)

% Choose default command line output for dasar
handles.output = hObject;

% Update handles structure
guidata(hObject, handles);

% UIWAIT makes dasar wait for user response (see UIRESUME)
% uiwait(handles.figure1);


% --- Outputs from this function are returned to the command line.
function varargout = dasar_OutputFcn(hObject, eventdata, handles) 
% varargout  cell array for returning output args (see VARARGOUT);
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Get default command line output from handles structure
varargout{1} = handles.output;


% --- Executes on button press in browse_btn.
function browse_btn_Callback(hObject, eventdata, handles)
% hObject    handle to browse_btn (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

global a;
[nama_file, nama_path] = uigetfile('*.png;*.jpg','Pilih gambar');
if ~isequal (nama_file,0)
    a = imread(fullfile(nama_path,nama_file));
    guidata(hObject,handles);
    axes(handles.pb1);
    imshow(a);
else
    return;
end



% --- Executes on button press in copy_btn.
function copy_btn_Callback(hObject, eventdata, handles)
% hObject    handle to copy_btn (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)


global a;

r = a(:,:,1);
g = a(:,:,2);
b = a(:,:,3);
newIm  = cat(3, r, g, b);

axes(handles.pb2);
imshow(newIm);



% --- Executes on button press in exit_btn.
function exit_btn_Callback(hObject, eventdata, handles)
% hObject    handle to exit_btn (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
close();


% --- Executes during object creation, after setting all properties.
function pb1_CreateFcn(hObject, eventdata, handles)
% hObject    handle to pb1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: place code in OpeningFcn to populate pb1


% --- Executes on button press in red_btn.
function red_btn_Callback(hObject, eventdata, handles)
% hObject    handle to red_btn (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hint: get(hObject,'Value') returns toggle state of red_btn
global a;

r = a(:,:,1);
g = a(:,:,2);
b = a(:,:,3);
z = zeros(size(a, 1), size(a, 2));
newIm  = cat(3, r, z, z);

axes(handles.pb3);
imshow(newIm);


% --- Executes on button press in green_btn.
function green_btn_Callback(hObject, eventdata, handles)
% hObject    handle to green_btn (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hint: get(hObject,'Value') returns toggle state of green_btn
global a;

r = a(:,:,1)==0;
g = a(:,:,2);
b = a(:,:,3)==0;
newIm  = cat(3, r, g, b);

axes(handles.pb3);
imshow(newIm);


% --- Executes on button press in blue_btn.
function blue_btn_Callback(hObject, eventdata, handles)
% hObject    handle to blue_btn (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hint: get(hObject,'Value') returns toggle state of blue_btn
global a;

r = a(:,:,1);
g = a(:,:,2);
b = a(:,:,3);
z = zeros(size(a, 1), size(a, 2));
newIm  = cat(3, z, z, b);

axes(handles.pb3);
imshow(newIm);


% --- Executes on button press in cyan_rb.
function cyan_rb_Callback(hObject, eventdata, handles)
% hObject    handle to cyan_rb (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hint: get(hObject,'Value') returns toggle state of cyan_rb
global a;

r = a(:,:,1);
g = a(:,:,2);
b = a(:,:,3);
z = zeros(size(a, 1), size(a, 2));
newIm  = cat(3, z, g, b);

axes(handles.pb3);
imshow(newIm);


% --- Executes on button press in magenta_rb.
function magenta_rb_Callback(hObject, eventdata, handles)
% hObject    handle to magenta_rb (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hint: get(hObject,'Value') returns toggle state of magenta_rb
global a;

r = a(:,:,1);
g = a(:,:,2);
b = a(:,:,3);
z = zeros(size(a, 1), size(a, 2));
newIm  = cat(3, r, z, b);

axes(handles.pb3);
imshow(newIm);


% --- Executes on button press in radiobutton6.
function radiobutton6_Callback(hObject, eventdata, handles)
% hObject    handle to radiobutton6 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hint: get(hObject,'Value') returns toggle state of radiobutton6
global a;

r = a(:,:,1);
g = a(:,:,2);
b = a(:,:,3);
z = zeros(size(a, 1), size(a, 2));
newIm  = cat(3, r, g, z);

axes(handles.pb3);
imshow(newIm);
